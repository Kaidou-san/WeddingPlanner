#pragma checksum "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\WeddingPlanner\Views\Home\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a3dd57c8e63ea7d7f9bc6f4d04b317b9cc36248"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Success), @"mvc.1.0.view", @"/Views/Home/Success.cshtml")]
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
#line 1 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3dd57c8e63ea7d7f9bc6f4d04b317b9cc36248", @"/Views/Home/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/fullheart.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("RSVP"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/emptyheart.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("unRSVP"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Welcome To the Wedding Planner!</h1>\r\n<a href=\"logout\">logout</a> |\r\n\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>Wedding</th>\r\n        <th>Date</th>\r\n        <th>Guest</th>\r\n        <th>Action</th>\r\n    </tr>\r\n");
#nullable restore
#line 13 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\WeddingPlanner\Views\Home\Success.cshtml"
      
        foreach (Wedding w in ViewBag.AllWeddings)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 357, "\"", 385, 2);
            WriteAttributeValue("", 364, "/wedding/", 364, 9, true);
#nullable restore
#line 17 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\WeddingPlanner\Views\Home\Success.cshtml"
WriteAttributeValue("", 373, w.WeddingId, 373, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\WeddingPlanner\Views\Home\Success.cshtml"
                                               Write(w.WedderOne);

#line default
#line hidden
#nullable disable
            WriteLiteral(" & ");
#nullable restore
#line 17 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\WeddingPlanner\Views\Home\Success.cshtml"
                                                              Write(w.WedderTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\WeddingPlanner\Views\Home\Success.cshtml"
               Write(w.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\WeddingPlanner\Views\Home\Success.cshtml"
               Write(w.GuestsWhoGoing.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\WeddingPlanner\Views\Home\Success.cshtml"
                      
                    if(w.GuestsWhoGoing.Any(a => a.UserId == ViewBag.User.UserId))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 666, "\"", 714, 4);
            WriteAttributeValue("", 673, "/UnRSVP/", 673, 8, true);
#nullable restore
#line 23 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\WeddingPlanner\Views\Home\Success.cshtml"
WriteAttributeValue("", 681, ViewBag.User.UserId, 681, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 701, "/", 701, 1, true);
#nullable restore
#line 23 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\WeddingPlanner\Views\Home\Success.cshtml"
WriteAttributeValue("", 702, w.WeddingId, 702, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3a3dd57c8e63ea7d7f9bc6f4d04b317b9cc362487875", async() => {
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
            WriteLiteral("</a>\r\n");
#nullable restore
#line 24 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\WeddingPlanner\Views\Home\Success.cshtml"
                    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 822, "\"", 868, 4);
            WriteAttributeValue("", 829, "/RSVP/", 829, 6, true);
#nullable restore
#line 25 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\WeddingPlanner\Views\Home\Success.cshtml"
WriteAttributeValue("", 835, ViewBag.User.UserId, 835, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 855, "/", 855, 1, true);
#nullable restore
#line 25 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\WeddingPlanner\Views\Home\Success.cshtml"
WriteAttributeValue("", 856, w.WeddingId, 856, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3a3dd57c8e63ea7d7f9bc6f4d04b317b9cc3624810010", async() => {
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
            WriteLiteral("</a>\r\n");
#nullable restore
#line 26 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\WeddingPlanner\Views\Home\Success.cshtml"
                    }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\WeddingPlanner\Views\Home\Success.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/addWedding\">New Wedding</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
