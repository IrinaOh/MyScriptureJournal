#pragma checksum "C:\Users\irina\source\repos\MyScriptureJournal\MyScriptureJournal\Pages\Scriptures\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52237b4d186f5010dd0b41cb0b929874cde98918"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyScriptureJournal.Pages.Scriptures.Pages_Scriptures_Details), @"mvc.1.0.razor-page", @"/Pages/Scriptures/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Scriptures/Details.cshtml", typeof(MyScriptureJournal.Pages.Scriptures.Pages_Scriptures_Details), @"{id:int?}")]
namespace MyScriptureJournal.Pages.Scriptures
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\irina\source\repos\MyScriptureJournal\MyScriptureJournal\Pages\_ViewImports.cshtml"
using MyScriptureJournal;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52237b4d186f5010dd0b41cb0b929874cde98918", @"/Pages/Scriptures/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e859221b4e15c0d01bab50b9361f69e2ae5c53d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Scriptures_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(76, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\irina\source\repos\MyScriptureJournal\MyScriptureJournal\Pages\Scriptures\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(121, 130, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Scripture</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(252, 50, false);
#line 15 "C:\Users\irina\source\repos\MyScriptureJournal\MyScriptureJournal\Pages\Scriptures\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Scripture.Book));

#line default
#line hidden
            EndContext();
            BeginContext(302, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(364, 46, false);
#line 18 "C:\Users\irina\source\repos\MyScriptureJournal\MyScriptureJournal\Pages\Scriptures\Details.cshtml"
       Write(Html.DisplayFor(model => model.Scripture.Book));

#line default
#line hidden
            EndContext();
            BeginContext(410, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(471, 53, false);
#line 21 "C:\Users\irina\source\repos\MyScriptureJournal\MyScriptureJournal\Pages\Scriptures\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Scripture.Chapter));

#line default
#line hidden
            EndContext();
            BeginContext(524, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(586, 49, false);
#line 24 "C:\Users\irina\source\repos\MyScriptureJournal\MyScriptureJournal\Pages\Scriptures\Details.cshtml"
       Write(Html.DisplayFor(model => model.Scripture.Chapter));

#line default
#line hidden
            EndContext();
            BeginContext(635, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(696, 51, false);
#line 27 "C:\Users\irina\source\repos\MyScriptureJournal\MyScriptureJournal\Pages\Scriptures\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Scripture.Verse));

#line default
#line hidden
            EndContext();
            BeginContext(747, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(809, 47, false);
#line 30 "C:\Users\irina\source\repos\MyScriptureJournal\MyScriptureJournal\Pages\Scriptures\Details.cshtml"
       Write(Html.DisplayFor(model => model.Scripture.Verse));

#line default
#line hidden
            EndContext();
            BeginContext(856, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(917, 50, false);
#line 33 "C:\Users\irina\source\repos\MyScriptureJournal\MyScriptureJournal\Pages\Scriptures\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Scripture.Note));

#line default
#line hidden
            EndContext();
            BeginContext(967, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1029, 46, false);
#line 36 "C:\Users\irina\source\repos\MyScriptureJournal\MyScriptureJournal\Pages\Scriptures\Details.cshtml"
       Write(Html.DisplayFor(model => model.Scripture.Note));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1136, 50, false);
#line 39 "C:\Users\irina\source\repos\MyScriptureJournal\MyScriptureJournal\Pages\Scriptures\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Scripture.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1248, 46, false);
#line 42 "C:\Users\irina\source\repos\MyScriptureJournal\MyScriptureJournal\Pages\Scriptures\Details.cshtml"
       Write(Html.DisplayFor(model => model.Scripture.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1294, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1341, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52237b4d186f5010dd0b41cb0b929874cde989188795", async() => {
                BeginContext(1397, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\irina\source\repos\MyScriptureJournal\MyScriptureJournal\Pages\Scriptures\Details.cshtml"
                           WriteLiteral(Model.Scripture.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1405, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1413, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52237b4d186f5010dd0b41cb0b929874cde9891811142", async() => {
                BeginContext(1435, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1451, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyScriptureJournal.Pages.Scriptures.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyScriptureJournal.Pages.Scriptures.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyScriptureJournal.Pages.Scriptures.DetailsModel>)PageContext?.ViewData;
        public MyScriptureJournal.Pages.Scriptures.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
