#pragma checksum "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Home\Buy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3929f0430a7a0dc4db90b3501e57c0e70c7a3c8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Buy), @"mvc.1.0.view", @"/Views/Home/Buy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3929f0430a7a0dc4db90b3501e57c0e70c7a3c8c", @"/Views/Home/Buy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0cfabe0b49a2ea3b364ec6f27b5c32b3c3b437b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Buy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <p>Get Order</p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3929f0430a7a0dc4db90b3501e57c0e70c7a3c8c3213", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"BikeId\"");
                BeginWriteAttribute("value", " value=\"", 136, "\"", 159, 1);
#nullable restore
#line 6 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Home\Buy.cshtml"
WriteAttributeValue("", 144, ViewBag.BikeId, 144, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <div class=\"input-group mb-3\">\r\n            ");
#nullable restore
#line 8 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Home\Buy.cshtml"
       Write(Html.LabelFor(x => x.User, null, new { @class = "input-group-text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 9 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Home\Buy.cshtml"
       Write(Html.TextBoxFor(x => x.User, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 10 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Home\Buy.cshtml"
       Write(Html.ValidationMessageFor(x => x.User));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"input-group mb-3\">\r\n            ");
#nullable restore
#line 13 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Home\Buy.cshtml"
       Write(Html.LabelFor(x => x.Address, null, new { @class = "input-group-text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 14 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Home\Buy.cshtml"
       Write(Html.TextBoxFor(x => x.Address, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 15 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Home\Buy.cshtml"
       Write(Html.ValidationMessageFor(x => x.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"input-group mb-3\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Home\Buy.cshtml"
       Write(Html.LabelFor(x => x.ContactPhone, null, new { @class = "input-group-text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 19 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Home\Buy.cshtml"
       Write(Html.TextBoxFor(x => x.ContactPhone, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 20 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Home\Buy.cshtml"
       Write(Html.ValidationMessageFor(x => x.ContactPhone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n");
                WriteLiteral("        <input type=\"submit\" class=\"btn btn-secondary\" style=\"width:30%\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
