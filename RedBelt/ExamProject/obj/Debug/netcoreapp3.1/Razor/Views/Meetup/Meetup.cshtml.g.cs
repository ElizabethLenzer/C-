#pragma checksum "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\Meetup\Meetup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20b94464f86e309f3f9f6fd26527f68d1d8a25a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Meetup_Meetup), @"mvc.1.0.view", @"/Views/Meetup/Meetup.cshtml")]
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
#line 1 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\_ViewImports.cshtml"
using ExamProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\_ViewImports.cshtml"
using ExamProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20b94464f86e309f3f9f6fd26527f68d1d8a25a1", @"/Views/Meetup/Meetup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0bac883cccd9063832b5b17a27d2cd5a8afd2a6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Meetup_Meetup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Meetup>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Meetup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RSVP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteMeetup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20b94464f86e309f3f9f6fd26527f68d1d8a25a15363", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Meetup</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20b94464f86e309f3f9f6fd26527f68d1d8a25a16537", async() => {
                WriteLiteral("\r\n<div class=\"card text-center\">\r\n    <div class=\"card-header\">\r\n        <h1>");
#nullable restore
#line 14 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\Meetup\Meetup.cshtml"
       Write(Model.MeetupTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n        <small>Created by: ");
#nullable restore
#line 15 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\Meetup\Meetup.cshtml"
                      Write(Model.Author.FullName());

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n    </div>\r\n    <div class=\"card-body\">\r\n    <h3 class=\"card-title\">Details ");
#nullable restore
#line 18 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\Meetup\Meetup.cshtml"
                              Write(Model.MeetupDetails);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    <h5>Date: ");
#nullable restore
#line 19 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\Meetup\Meetup.cshtml"
         Write(Model.MeetUpDate.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n    <p class=\"card-text\">Participants\r\n        \r\n");
#nullable restore
#line 22 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\Meetup\Meetup.cshtml"
         foreach (Attendance rsvp in  Model.MeetupAttendees)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\r\n                <small>");
#nullable restore
#line 25 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\Meetup\Meetup.cshtml"
                  Write(rsvp.User.FullName());

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n            </div>\r\n");
#nullable restore
#line 27 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\Meetup\Meetup.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </p>\r\n\r\n    </div>\r\n    <div class=\"card-footer text-muted\">\r\n        Created :");
#nullable restore
#line 32 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\Meetup\Meetup.cshtml"
            Write(Model.CreatedAt);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n        <div>\r\n            Updated: ");
#nullable restore
#line 34 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\Meetup\Meetup.cshtml"
                Write(Model.UpdatedAt);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 38 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\Meetup\Meetup.cshtml"
  bool existingRSVP = Model.MeetupAttendees
.Any(rsvp => rsvp.UserId == Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\Meetup\Meetup.cshtml"
 if(Context.Session.GetInt32("UserId") !=Model.UserId)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20b94464f86e309f3f9f6fd26527f68d1d8a25a110252", async() => {
                    WriteLiteral("\r\n        <button class=\"btn btn-info btn-sm\">\r\n");
#nullable restore
#line 44 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\Meetup\Meetup.cshtml"
             if (existingRSVP)
            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("            <span>Un-RSVP</span>\r\n");
#nullable restore
#line 47 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\Meetup\Meetup.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("            <span>RSVP</span>\r\n");
#nullable restore
#line 51 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\Meetup\Meetup.cshtml"
            }

#line default
#line hidden
#nullable disable
                    WriteLiteral("        </button>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-meetupId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\Meetup\Meetup.cshtml"
                                                                WriteLiteral(Model.MeetupId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["meetupId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-meetupId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["meetupId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\Meetup\Meetup.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20b94464f86e309f3f9f6fd26527f68d1d8a25a114208", async() => {
                    WriteLiteral("\r\n            <button class=\"btn btn-danger\">Delete</button>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("asp", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-meetupId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\Meetup\Meetup.cshtml"
                                                                            WriteLiteral(Model.MeetupId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["meetupId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-meetupId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["meetupId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\eliza\OneDrive\Documents\Coding Dojo\C#\RedBelt\ExamProject\Views\Meetup\Meetup.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <a href=\"/Dashboard\" class=\"btn btn-primary\">Dashboard</a>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20b94464f86e309f3f9f6fd26527f68d1d8a25a117713", async() => {
                    WriteLiteral("\r\n        <button class=\"btn btn-warning\">Log Out</button>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
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
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Meetup> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
