#pragma checksum "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d9b08622cd7728ff892eb42783d1f8d544e0819"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Post.cshtml", typeof(AspNetCore.Views_Home_Post))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\NewGit\src\TochalUI\Views\_ViewImports.cshtml"
using TochalUI;

#line default
#line hidden
#line 2 "E:\NewGit\src\TochalUI\Views\_ViewImports.cshtml"
using TochalUI.Models;

#line default
#line hidden
#line 1 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
using Tochal.Core.DomainModels.Entity.Blog;

#line default
#line hidden
#line 2 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
using Tochal.Core.DomainModels.SSOT;

#line default
#line hidden
#line 3 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
using Tochal.Core.DomainModels.Entity.Menu;

#line default
#line hidden
#line 5 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 7 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
using System.Globalization;

#line default
#line hidden
#line 8 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d9b08622cd7728ff892eb42783d1f8d544e0819", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f0b304abae5b095fdcac43bf7aed30b591793f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContentEntity>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/styles/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/styles/page4.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/background.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("background"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/background2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(310, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
  
    DetailTypeSSOT? DetailType = (DetailTypeSSOT)TempData["DetailType"];

#line default
#line hidden
            BeginContext(427, 807, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d9b08622cd7728ff892eb42783d1f8d544e08197097", async() => {
                BeginContext(433, 175, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\" />\r\n    ");
                EndContext();
                BeginContext(608, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d9b08622cd7728ff892eb42783d1f8d544e08197669", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(659, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(665, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d9b08622cd7728ff892eb42783d1f8d544e08199001", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(716, 28, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", "\r\n          href=\"", 744, "\"", 819, 3);
                WriteAttributeValue("", 762, "./node_modules/", 762, 15, true);
                WriteAttributeValue("", 777, "@", 777, 1, true);
                WriteAttributeValue("", 779, "fortawesome/fontawesome-free/css/all.css", 779, 40, true);
                EndWriteAttribute();
                BeginContext(820, 377, true);
                WriteLiteral(@" />
    <link rel=""stylesheet""
          href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css""
          integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T""
          crossorigin=""anonymous"" />
    <link rel=""stylesheet""
          href=""//code.jquery.com/ui/1.12.1/themes/smoothness/jquery-ui.css"" />
    <title>");
                EndContext();
                BeginContext(1198, 19, false);
#line 28 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
      Write(Localizer["Tochal"]);

#line default
#line hidden
                EndContext();
                BeginContext(1217, 10, true);
                WriteLiteral("</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1234, 286, true);
            WriteLiteral(@"
<div class=""filterdiv""
     style=""display:none;width: 100vw;height: 100vh;background-color: rgba(255, 255, 255, 0.7);z-index: 5000;position: fixed;top: 0;""></div>

<section class=""page-events"">
    <section class=""background"">
        <div class=""backgroundImage"">
            ");
            EndContext();
            BeginContext(1520, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d9b08622cd7728ff892eb42783d1f8d544e081912666", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1574, 455, true);
            WriteLiteral(@"
            <img src=""https://cdn.cnn.com/cnnnext/dam/assets/150826163012-photo-adrian-nordenborg-skiier-filip-nilsson-iran-tochal-3900m-teheran-www-pathfindertravels-eu-super-169.jpg""
                 alt=""background""
                 style=""display: none"" />
            <img src=""http://www.intercaspian.com/photobank/iran/tehran/images/tochal-01735a.jpg""
                 alt=""background""
                 style=""display: none"" />
            ");
            EndContext();
            BeginContext(2029, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d9b08622cd7728ff892eb42783d1f8d544e081914387", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2142, 128, true);
            WriteLiteral("\r\n        </div>\r\n    </section>\r\n\r\n\r\n\r\n\r\n    <section class=\"page-content\">\r\n        <div class=\"page-header\">\r\n            <p>");
            EndContext();
            BeginContext(2271, 21, false);
#line 54 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
          Write(Localizer["LastPost"]);

#line default
#line hidden
            EndContext();
            BeginContext(2292, 22, true);
            WriteLiteral("</p>\r\n            <h4>");
            EndContext();
            BeginContext(2315, 21, false);
#line 55 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
           Write(Localizer["LastPost"]);

#line default
#line hidden
            EndContext();
            BeginContext(2336, 54, true);
            WriteLiteral("</h4>\r\n        </div>\r\n        <div class=\"content\">\r\n");
            EndContext();
#line 58 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
             if (Model.Count > 0)
            {
                foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2504, 59, true);
            WriteLiteral("                    <article>\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2563, "\"", 2612, 2);
#line 63 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
WriteAttributeValue("", 2569, fileConfig.Value.WebAddress, 2569, 28, false);

#line default
#line hidden
#line 63 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
WriteAttributeValue("", 2597, item.MainImage, 2597, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2613, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(2727, 127, true);
            WriteLiteral("                        <div class=\"article-title\">\r\n                            <div>\r\n                                <span> ");
            EndContext();
            BeginContext(2854, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d9b08622cd7728ff892eb42783d1f8d544e081917698", async() => {
                BeginContext(2937, 10, false);
#line 67 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
                                                                                                                    Write(item.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-DetailType", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 67 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
                                                                        WriteLiteral(DetailType);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["DetailType"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-DetailType", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["DetailType"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 67 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
                                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2951, 77, true);
            WriteLiteral("</span>\r\n                            </div>\r\n                            <h1>");
            EndContext();
            BeginContext(3029, 13, false);
#line 69 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
                           Write(item.SubTitle);

#line default
#line hidden
            EndContext();
            BeginContext(3042, 72, true);
            WriteLiteral("</h1>\r\n                            <p>\r\n                                ");
            EndContext();
            BeginContext(3115, 17, false);
#line 71 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
                           Write(item.ShortContent);

#line default
#line hidden
            EndContext();
            BeginContext(3132, 100, true);
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </article>\r\n");
            EndContext();
#line 75 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
                }
            }
            else
            {

#line default
#line hidden
            BeginContext(3299, 151, true);
            WriteLiteral("                <label class=\"label label-info\" style=\"margin:50px;padding:10px 15px;font-size:12px;text-align:center;background-color:cornflowerblue\">");
            EndContext();
            BeginContext(3451, 20, false);
#line 79 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
                                                                                                                                                  Write(Localizer["Eror404"]);

#line default
#line hidden
            EndContext();
            BeginContext(3471, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 80 "E:\NewGit\src\TochalUI\Views\Home\Post.cshtml"
            }

#line default
#line hidden
            BeginContext(3496, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(6776, 156, true);
            WriteLiteral("\r\n        </div>\r\n    </section>\r\n\r\n\r\n\r\n</section>\r\n\r\n<div style=\"background-color:white;z-index:-1;height:100%;width:100vw;display: table-cell;\"></div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<FileConfig> fileConfig { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ContentEntity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
