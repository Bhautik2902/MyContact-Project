#pragma checksum "F:\Training@maven\MyContact\WebApplication1\Views\MyContacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cdea254da3d5423ac106fb30c34fec82952a468"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyContacts), @"mvc.1.0.view", @"/Views/MyContacts.cshtml")]
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
#nullable restore
#line 1 "F:\Training@maven\MyContact\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Training@maven\MyContact\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cdea254da3d5423ac106fb30c34fec82952a468", @"/Views/MyContacts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_MyContacts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style_mycontactspage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\Training@maven\MyContact\WebApplication1\Views\MyContacts.cshtml"
  
    ViewData["Title"] = "My Contacts";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cdea254da3d5423ac106fb30c34fec82952a4684994", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6cdea254da3d5423ac106fb30c34fec82952a4685256", async() => {
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
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cdea254da3d5423ac106fb30c34fec82952a4687138", async() => {
                WriteLiteral("\r\n    <div class=\"wrapper\">\r\n        <div class=\"container\">\r\n            <div class=\"header\">\r\n                <div class=\"flex-wrap\">\r\n                    <div class=\"logo\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 346, "\"", 383, 1);
#nullable restore
#line 15 "F:\Training@maven\MyContact\WebApplication1\Views\MyContacts.cshtml"
WriteAttributeValue("", 353, Url.Action("Homepage","Home"), 353, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6cdea254da3d5423ac106fb30c34fec82952a4687995", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a>\r\n                    </div>\r\n                    <div class=\"button\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 533, "\"", 567, 1);
#nullable restore
#line 18 "F:\Training@maven\MyContact\WebApplication1\Views\MyContacts.cshtml"
WriteAttributeValue("", 540, Url.Action("Index","Home"), 540, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><button class=""button-primary"">Log out</button></a>
                    </div>
                </div>
            </div>

            <div class=""main"">
                <div class=""content"">
                    <div class=""title"">
                        <h1>My Contacts</h1>
                    </div>
                    <div class=""table-container"">
                        <table class=""content-table"">
                            <thead>
                                <tr>
                                    <th><input type=""checkbox"" class=""selectAll""></th>
                                    <th>No.</th>
                                    <th>First Name</th>
                                    <th>Last Name</th>
                                    <th>Email</th>
                                    <th>View</th>
                                </tr>
                            </thead>

                            <tbody>
                                <tr>
                     ");
                WriteLiteral(@"               <td><input type=""checkbox"" class=""selectContact""></td>
                                    <td>1</td>
                                    <td>Bhautik</td>
                                    <td>Savaliya</td>
                                    <td>bhautiksavaliya2000@gmail.com</td>
                                    <td><button class=""button-primary btn"">Edit</button></td>
                                </tr>
                                <tr>
                                    <td><input type=""checkbox"" class=""selectContact""></td>
                                    <td>1</td>
                                    <td>Bhautik</td>
                                    <td>Savaliya</td>
                                    <td>bhautiksavaliya2000@gmail.com</td>
                                    <td><button class=""button-primary btn"">Edit</button></td>
                                </tr>
                                <tr>
                                    <td><input type");
                WriteLiteral(@"=""checkbox"" class=""selectContact""></td>
                                    <td>1</td>
                                    <td>Bhautik</td>
                                    <td>Savaliya</td>
                                    <td>bhautiksavaliya2000@gmail.com</td>
                                    <td><button class=""button-primary btn"">Edit</button></td>
                                </tr>
                                <tr>
                                    <td><input type=""checkbox"" class=""selectContact""></td>
                                    <td>1</td>
                                    <td>Bhautik</td>
                                    <td>Savaliya</td>
                                    <td>bhautiksavaliya2000@gmail.com</td>
                                    <td><button class=""button-primary btn"">Edit</button></td>
                                </tr>
                                <tr>
                                    <td><input type=""checkbox"" class=""selectConta");
                WriteLiteral(@"ct""></td>
                                    <td>1</td>
                                    <td>Bhautik</td>
                                    <td>Savaliya</td>
                                    <td>bhautiksavaliya2000@gmail.com</td>
                                    <td><button class=""button-primary btn"">Edit</button></td>
                                </tr>
                                <tr>
                                    <td><input type=""checkbox"" class=""selectContact""></td>
                                    <td>1</td>
                                    <td>Bhautik</td>
                                    <td>Savaliya</td>
                                    <td>bhautiksavaliya2000@gmail.com</td>
                                    <td><button class=""button-primary btn"">Edit</button></td>
                                </tr>
                                <tr>
                                    <td><input type=""checkbox"" class=""selectContact""></td>
                   ");
                WriteLiteral(@"                 <td>1</td>
                                    <td>Bhautik</td>
                                    <td>Savaliya</td>
                                    <td>bhautiksavaliya2000@gmail.com</td>
                                    <td><button class=""button-primary btn"">Edit</button></td>
                                </tr>
                                <tr>
                                    <td><input type=""checkbox"" class=""selectContact""></td>
                                    <td>1</td>
                                    <td>Bhautik</td>
                                    <td>Savaliya</td>
                                    <td>bhautiksavaliya2000@gmail.com</td>
                                    <td><button class=""button-primary btn"">Edit</button></td>
                                </tr>
                                <tr>
                                    <td><input type=""checkbox"" class=""selectContact""></td>
                                    <td>1</td>
 ");
                WriteLiteral(@"                                   <td>Bhautik</td>
                                    <td>Savaliya</td>
                                    <td>bhautiksavaliya2000@gmail.com</td>
                                    <td><button class=""button-primary btn"">Edit</button></td>
                                </tr>
                                <tr>
                                    <td><input type=""checkbox"" class=""selectContact""></td>
                                    <td>1</td>
                                    <td>Bhautik</td>
                                    <td>Savaliya</td>
                                    <td>bhautiksavaliya2000@gmail.com</td>
                                    <td><button class=""button-primary btn"">Edit</button></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <div class=""button bottom-btn"">
                        <a");
                BeginWriteAttribute("href", " href=\"", 6682, "\"", 6689, 0);
                EndWriteAttribute();
                WriteLiteral("><button class=\"button-primary\">Delete</button></a>\r\n\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 6771, "\"", 6816, 1);
#nullable restore
#line 128 "F:\Training@maven\MyContact\WebApplication1\Views\MyContacts.cshtml"
WriteAttributeValue("", 6778, Url.Action("AddContact","AddContact"), 6778, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><button class=\"button-primary\">Add New</button></a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591