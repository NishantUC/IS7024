#pragma checksum "C:\Users\prabh\Documents\GitHub\IS7024\LicenseOwners\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "771bf56bb1e1b9ce79013c3071c609ec71bb7552"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LicenseOwners.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(LicenseOwners.Pages.Pages_Index), null)]
namespace LicenseOwners.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\prabh\Documents\GitHub\IS7024\LicenseOwners\Pages\_ViewImports.cshtml"
using LicenseOwners;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771bf56bb1e1b9ce79013c3071c609ec71bb7552", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"956d980ac2960126a7001eca165e387cc713884c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\prabh\Documents\GitHub\IS7024\LicenseOwners\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";
    List<LicenseOwners.Models.BusinessLicenseOwners> businessLicenseOwners = (List<LicenseOwners.Models.BusinessLicenseOwners>)ViewData["BusinessLicenseOwners"];
    HashSet<String> BusinessActivitySet = (HashSet<String>) ViewData["BusinessActivitySet"];
   

#line default
#line hidden
            BeginContext(333, 25, true);
            WriteLiteral("\r\n\r\n\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(358, 739, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "771bf56bb1e1b9ce79013c3071c609ec71bb75524050", async() => {
                BeginContext(378, 220, true);
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-3\">\r\n                    <label for=\"Activity\">Business Activity</label>\r\n                    <select name=\"Activity\" class=\"form-control\">\r\n");
                EndContext();
#line 18 "C:\Users\prabh\Documents\GitHub\IS7024\LicenseOwners\Pages\Index.cshtml"
                          
                        foreach (var activity in BusinessActivitySet)
                        {
                           

#line default
#line hidden
                BeginContext(753, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(781, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "771bf56bb1e1b9ce79013c3071c609ec71bb75525079", async() => {
                    BeginContext(808, 8, false);
#line 22 "C:\Users\prabh\Documents\GitHub\IS7024\LicenseOwners\Pages\Index.cshtml"
                                                 Write(activity);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 22 "C:\Users\prabh\Documents\GitHub\IS7024\LicenseOwners\Pages\Index.cshtml"
                               WriteLiteral(activity);

#line default
#line hidden
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
                EndContext();
                BeginContext(825, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 23 "C:\Users\prabh\Documents\GitHub\IS7024\LicenseOwners\Pages\Index.cshtml"
                            }
                        
                        

#line default
#line hidden
                BeginContext(911, 179, true);
                WriteLiteral("                    </select>\r\n                </div>\r\n\r\n\r\n                <input class=\"btn-primary\" id=\"submitButton\" type=\"submit\" value=\"Search\">\r\n            </div>\r\n        ");
                EndContext();
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
            EndContext();
            BeginContext(1097, 30, true);
            WriteLiteral("\r\n\r\n\r\n\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
#line 42 "C:\Users\prabh\Documents\GitHub\IS7024\LicenseOwners\Pages\Index.cshtml"
 if (Model.DataFetched)
{

#line default
#line hidden
            BeginContext(1155, 609, true);
            WriteLiteral(@"<div class=""text-center"">
    <h1 class=""display-4"">List of Business Owners</h1>
    <table border=""1"">
        <tr>
            <td><strong>Account Number</strong></td>
            <td><strong>License Number</strong></td>
            <td><strong>Business Name</strong></td>
            <td><strong>City</strong></td>
            <td><strong>State</strong></td>
            <td><strong>Business Activity</strong></td>
            <td><strong>Owner First Name</strong></td>
            <td><strong>Owner Last Name</strong></td>
            <td><strong>Owner Title</strong></td>
        </tr>


");
            EndContext();
#line 60 "C:\Users\prabh\Documents\GitHub\IS7024\LicenseOwners\Pages\Index.cshtml"
          
            foreach (LicenseOwners.Models.BusinessLicenseOwners businessLicenseOwner in businessLicenseOwners)
            {

#line default
#line hidden
            BeginContext(1903, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1942, 34, false);
#line 64 "C:\Users\prabh\Documents\GitHub\IS7024\LicenseOwners\Pages\Index.cshtml"
               Write(businessLicenseOwner.AccountNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1976, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2004, 34, false);
#line 65 "C:\Users\prabh\Documents\GitHub\IS7024\LicenseOwners\Pages\Index.cshtml"
               Write(businessLicenseOwner.LicenseNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2038, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2066, 40, false);
#line 66 "C:\Users\prabh\Documents\GitHub\IS7024\LicenseOwners\Pages\Index.cshtml"
               Write(businessLicenseOwner.DoingBusinessAsName);

#line default
#line hidden
            EndContext();
            BeginContext(2106, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2134, 25, false);
#line 67 "C:\Users\prabh\Documents\GitHub\IS7024\LicenseOwners\Pages\Index.cshtml"
               Write(businessLicenseOwner.City);

#line default
#line hidden
            EndContext();
            BeginContext(2159, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2187, 26, false);
#line 68 "C:\Users\prabh\Documents\GitHub\IS7024\LicenseOwners\Pages\Index.cshtml"
               Write(businessLicenseOwner.State);

#line default
#line hidden
            EndContext();
            BeginContext(2213, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2241, 37, false);
#line 69 "C:\Users\prabh\Documents\GitHub\IS7024\LicenseOwners\Pages\Index.cshtml"
               Write(businessLicenseOwner.BusinessActivity);

#line default
#line hidden
            EndContext();
            BeginContext(2278, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2306, 35, false);
#line 70 "C:\Users\prabh\Documents\GitHub\IS7024\LicenseOwners\Pages\Index.cshtml"
               Write(businessLicenseOwner.OwnerFirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2341, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2369, 34, false);
#line 71 "C:\Users\prabh\Documents\GitHub\IS7024\LicenseOwners\Pages\Index.cshtml"
               Write(businessLicenseOwner.OwnerLastName);

#line default
#line hidden
            EndContext();
            BeginContext(2403, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2431, 31, false);
#line 72 "C:\Users\prabh\Documents\GitHub\IS7024\LicenseOwners\Pages\Index.cshtml"
               Write(businessLicenseOwner.OwnerTitle);

#line default
#line hidden
            EndContext();
            BeginContext(2462, 28, true);
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 75 "C:\Users\prabh\Documents\GitHub\IS7024\LicenseOwners\Pages\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(2516, 26, true);
            WriteLiteral("    </table>\r\n\r\n\r\n</div>\r\n");
            EndContext();
#line 81 "C:\Users\prabh\Documents\GitHub\IS7024\LicenseOwners\Pages\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2545, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
