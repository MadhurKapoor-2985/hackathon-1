#pragma checksum "C:\Users\harendra\source\repos\Hackathon.Web\Views\CreditCard\ApplyCreditCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc2d181e35b71c70cd26a863e0a7a26898ac57e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CreditCard_ApplyCreditCard), @"mvc.1.0.view", @"/Views/CreditCard/ApplyCreditCard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CreditCard/ApplyCreditCard.cshtml", typeof(AspNetCore.Views_CreditCard_ApplyCreditCard))]
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
#line 1 "C:\Users\harendra\source\repos\Hackathon.Web\Views\_ViewImports.cshtml"
using Hackathon.Web;

#line default
#line hidden
#line 2 "C:\Users\harendra\source\repos\Hackathon.Web\Views\_ViewImports.cshtml"
using Hackathon.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc2d181e35b71c70cd26a863e0a7a26898ac57e2", @"/Views/CreditCard/ApplyCreditCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b81c2465303850e0b8217334bc96cfe1dc42d589", @"/Views/_ViewImports.cshtml")]
    public class Views_CreditCard_ApplyCreditCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CreditCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadAndAuthenticate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\harendra\source\repos\Hackathon.Web\Views\CreditCard\ApplyCreditCard.cshtml"
  
    ViewData["Title"] = "ApplyCreditCard";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(100, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(102, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98caa473ecf34c15bba974f5c4b25e49", async() => {
                BeginContext(108, 62, true);
                WriteLiteral("\r\n    <title>Apply For Credit Cards Online - My Bank</title>\r\n");
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
            BeginContext(177, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(179, 1555, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48d96ab452834678b24eccc0d0738e42", async() => {
                BeginContext(185, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 11 "C:\Users\harendra\source\repos\Hackathon.Web\Views\CreditCard\ApplyCreditCard.cshtml"
       CustomerDetails UserInfo = (CustomerDetails)TempData["CustDetails"];
        NewCardDetails newCardDetails = (NewCardDetails) TempData["newCardDetails"];

#line default
#line hidden
                BeginContext(350, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(358, 1360, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57714142450946e68f2114eee4b4694b", async() => {
                    BeginContext(471, 177, true);
                    WriteLiteral("\r\n            <div align=\"center\">\r\n                <h1 class=\"line-em-up\">Apply For Credit Cards Online</h1>\r\n                <table>\r\n                    <tr><td><b>Name:</b> ");
                    EndContext();
                    BeginContext(649, 34, false);
#line 17 "C:\Users\harendra\source\repos\Hackathon.Web\Views\CreditCard\ApplyCreditCard.cshtml"
                                    Write(UserInfo.body.CustomerDetails.Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(683, 54, true);
                    WriteLiteral("</td></tr>\r\n                    <tr><td><b>Email:</b> ");
                    EndContext();
                    BeginContext(738, 35, false);
#line 18 "C:\Users\harendra\source\repos\Hackathon.Web\Views\CreditCard\ApplyCreditCard.cshtml"
                                     Write(UserInfo.body.CustomerDetails.Email);

#line default
#line hidden
                    EndContext();
                    BeginContext(773, 57, true);
                    WriteLiteral("</td></tr>\r\n                    <tr><td><b>Phone No:</b> ");
                    EndContext();
                    BeginContext(831, 41, false);
#line 19 "C:\Users\harendra\source\repos\Hackathon.Web\Views\CreditCard\ApplyCreditCard.cshtml"
                                        Write(UserInfo.body.CustomerDetails.PhoneNumber);

#line default
#line hidden
                    EndContext();
                    BeginContext(872, 65, true);
                    WriteLiteral("</td></tr>\r\n                    <tr><td><b>Card Type:</b>My Bank ");
                    EndContext();
                    BeginContext(938, 43, false);
#line 20 "C:\Users\harendra\source\repos\Hackathon.Web\Views\CreditCard\ApplyCreditCard.cshtml"
                                                Write(newCardDetails.body.CardDetails.CardSegment);

#line default
#line hidden
                    EndContext();
                    BeginContext(981, 730, true);
                    WriteLiteral(@" Card</td></tr>
                    <tr><td><h4>Please Upload your photo for Authentication:</h4></td></tr>
                    <tr>
                        <td>
                            <b>Note:</b><ul>
                                <li>Take a selfie/Upload your recent photo in jpeg format</li>
                                <li>Image size should not exceed 2MB</li>
                            </ul>
                        </td>
                    </tr>
                    <tr><td><input type=""file"" accept=""image/jpeg"" capture=""camera"" name=""files"" /></td></tr>
                    <tr><td><input type=""submit"" value=""Upload And Verify"" /></td></tr>
                </table>
            </div>
        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1718, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
