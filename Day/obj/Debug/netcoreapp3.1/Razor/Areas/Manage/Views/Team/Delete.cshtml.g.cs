#pragma checksum "C:\Users\Yusifiz\Desktop\DAY-BackEnd\Day\Areas\Manage\Views\Team\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5a34c27655b8492344e8483d465eb432d910b16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Team_Delete), @"mvc.1.0.view", @"/Areas/Manage/Views/Team/Delete.cshtml")]
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
#line 1 "C:\Users\Yusifiz\Desktop\DAY-BackEnd\Day\Areas\Manage\Views\_ViewImports.cshtml"
using Day.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5a34c27655b8492344e8483d465eb432d910b16", @"/Areas/Manage/Views/Team/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c09ad8bf320687a88045ca486e62967f36e7bd84", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Team_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeamMember>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/team-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top rounded-circle w-50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Yusifiz\Desktop\DAY-BackEnd\Day\Areas\Manage\Views\Team\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card p-4 shadow\">\r\n    <div class=\"team-member-img d-flex justify-content-center\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a5a34c27655b8492344e8483d465eb432d910b165239", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"card-body text-center\">\r\n        <h5 class=\"card-title m-0\">");
#nullable restore
#line 11 "C:\Users\Yusifiz\Desktop\DAY-BackEnd\Day\Areas\Manage\Views\Team\Delete.cshtml"
                              Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <span class=\"card-desc fw-light\">");
#nullable restore
#line 12 "C:\Users\Yusifiz\Desktop\DAY-BackEnd\Day\Areas\Manage\Views\Team\Delete.cshtml"
                                    Write(Model.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <i class=\"card-text mt-3 fw-medium d-block text-secondary\">");
#nullable restore
#line 13 "C:\Users\Yusifiz\Desktop\DAY-BackEnd\Day\Areas\Manage\Views\Team\Delete.cshtml"
                                                              Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n\r\n        <ul class=\"team-social-list justify-content-center mt-3 mb-0 text-secondary\">\r\n            <li class=\"team-social-list-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 674, "\"", 698, 1);
#nullable restore
#line 17 "C:\Users\Yusifiz\Desktop\DAY-BackEnd\Day\Areas\Manage\Views\Team\Delete.cshtml"
WriteAttributeValue("", 681, Model.TwitterUrl, 681, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-twitter\"></i></a>\r\n            </li>\r\n            <li class=\"team-social-list-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 827, "\"", 852, 1);
#nullable restore
#line 20 "C:\Users\Yusifiz\Desktop\DAY-BackEnd\Day\Areas\Manage\Views\Team\Delete.cshtml"
WriteAttributeValue("", 834, Model.FacebookUrl, 834, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-twitter\"></i></a>\r\n\r\n            </li>\r\n            <li class=\"team-social-list-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 983, "\"", 1009, 1);
#nullable restore
#line 24 "C:\Users\Yusifiz\Desktop\DAY-BackEnd\Day\Areas\Manage\Views\Team\Delete.cshtml"
WriteAttributeValue("", 990, Model.InstagramUrl, 990, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-twitter\"></i></a>\r\n\r\n            </li>\r\n            <li class=\"team-social-list-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1140, "\"", 1165, 1);
#nullable restore
#line 28 "C:\Users\Yusifiz\Desktop\DAY-BackEnd\Day\Areas\Manage\Views\Team\Delete.cshtml"
WriteAttributeValue("", 1147, Model.LinkedinUrl, 1147, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-twitter\"></i></a>\r\n\r\n            </li>\r\n        </ul>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5a34c27655b8492344e8483d465eb432d910b169592", async() => {
                WriteLiteral("\r\n            <button type=\"submit\" class=\"text-danger\">Delete</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamMember> Html { get; private set; }
    }
}
#pragma warning restore 1591