using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Linq; 
using Tochal.Infrastructure.DataLayer.Context; 
using Microsoft.AspNetCore.DataProtection.Repositories;
using DNTCommon.Web.Core;
using Tochal.Core.DomainModels.Entity.Identity;
using Tochal.Core.Common.GuardToolkit;

namespace Tochal.Infrastructure.Services.Identity
{
    public class DataProtectionKeyService : IXmlRepository
    {
        private readonly IServiceProvider _serviceProvider;

        public DataProtectionKeyService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _serviceProvider.CheckArgumentIsNull(nameof(_serviceProvider));
        }

        public IReadOnlyCollection<XElement> GetAllElements()
        {
            return _serviceProvider.RunScopedService<ReadOnlyCollection<XElement>, IUnitOfWork>(context =>
              {
                  var dataProtectionKeys = context.Set<AppDataProtectionKey>();
                  return new ReadOnlyCollection<XElement>(dataProtectionKeys.Select(k => XElement.Parse(k.XmlData)).ToList());
              });
        }

        public void StoreElement(XElement element, string friendlyName)
        {
            // We need a separate context to call its SaveChanges several times,
            // without using the current request's context and changing its internal state.
            _serviceProvider.RunScopedService<IUnitOfWork>(context =>
            {
                var dataProtectionKeys = context.Set<AppDataProtectionKey>();
                var entity = dataProtectionKeys.SingleOrDefault(k => k.FriendlyName == friendlyName);
                if (null != entity)
                {
                    entity.XmlData = element.ToString();
                    dataProtectionKeys.Update(entity);
                }
                else
                {
                    dataProtectionKeys.Add(new AppDataProtectionKey
                    {
                        FriendlyName = friendlyName,
                        XmlData = element.ToString()
                    });
                }
                context.SaveChanges();
            });
        }
    }
}