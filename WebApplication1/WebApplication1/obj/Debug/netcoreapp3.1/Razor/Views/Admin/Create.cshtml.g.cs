#pragma checksum "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "992f6f37f9f3851838345e2d3b769f83a62fe5a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Create), @"mvc.1.0.view", @"/Views/Admin/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"992f6f37f9f3851838345e2d3b769f83a62fe5a5", @"/Views/Admin/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0cfabe0b49a2ea3b364ec6f27b5c32b3c3b437b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Bike>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "992f6f37f9f3851838345e2d3b769f83a62fe5a53340", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("        <div class=\"mb-3\">\r\n            ");
#nullable restore
#line 7 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"
       Write(Html.LabelFor(x => x.Name, null, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 8 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"
       Write(Html.TextBoxFor(x => x.Name, null, new { @class = "form-control", placeholder = "Name" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 9 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            ");
#nullable restore
#line 12 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"
       Write(Html.LabelFor(x => x.Company, null, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 13 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"
       Write(Html.TextBoxFor(x => x.Company, null, new { @class = "form-control", placeholder = "Company" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 14 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.Company));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"input-group mb-3\">\r\n            <label class=\"input-group-text\" for=\"TypeId\">Types</label>\r\n            <select class=\"form-select\" id=\"TypeId\" name=\"TypeId\" style=\"width:90%;\">\r\n");
#nullable restore
#line 19 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"
                 foreach (var item in ViewBag.Types)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "992f6f37f9f3851838345e2d3b769f83a62fe5a56172", async() => {
#nullable restore
#line 21 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"
                                            Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"
                       WriteLiteral(item.TypeId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n        </div>\r\n        <div class=\"input-group mb-3\">\r\n            <label class=\"input-group-text\" for=\"ModelId\">Models</label>\r\n            <select class=\"form-select\" id=\"ModelId\" name=\"ModelId\" style=\"width:90%;\">\r\n");
#nullable restore
#line 28 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"
                 foreach (var item in ViewBag.Models)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "992f6f37f9f3851838345e2d3b769f83a62fe5a58902", async() => {
#nullable restore
#line 30 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"
                                             Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"
                       WriteLiteral(item.ModelId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n        </div>\r\n        <div class=\"input-group mb-3\">\r\n            <label class=\"input-group-text\" for=\"StyleId\">Styles</label>\r\n            <select class=\"form-select\" id=\"StyleId\" name=\"StyleId\" style=\"width:90%;\">\r\n");
#nullable restore
#line 38 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"
                 foreach (var item in ViewBag.Styles)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "992f6f37f9f3851838345e2d3b769f83a62fe5a511636", async() => {
#nullable restore
#line 40 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"
                                             Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"
                       WriteLiteral(item.StyleId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"
       Write(Html.LabelFor(x => x.Price, null, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 46 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"
       Write(Html.TextBoxFor(x => x.Price, null, new { @class = "form-control", placeholder = "Price" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 47 "C:\Users\Family\source\repos\ASP.NET-practice\WebApplication1\WebApplication1\Views\Admin\Create.cshtml"
       Write(Html.ValidationMessageFor(x => x.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            <input type=\"submit\" class=\"btn btn-dark\" id=\"exampleFormControlInput1\" value=\"Create\" style=\"width:100%;\">\r\n        </div>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Bike> Html { get; private set; }
    }
}
#pragma warning restore 1591