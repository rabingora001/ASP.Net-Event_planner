#pragma checksum "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb9a4382f1fa0bed51df283c91071ae9d0530e34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DojoActivity_Dashboard), @"mvc.1.0.view", @"/Views/DojoActivity/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DojoActivity/Dashboard.cshtml", typeof(AspNetCore.Views_DojoActivity_Dashboard))]
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
#line 1 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/_ViewImports.cshtml"
using DojoActivity;

#line default
#line hidden
#line 1 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
using DojoActivity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb9a4382f1fa0bed51df283c91071ae9d0530e34", @"/Views/DojoActivity/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cdfec9d805dd1e79856c214e66b78fc3e086777", @"/Views/_ViewImports.cshtml")]
    public class Views_DojoActivity_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Activity>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 681, true);
            WriteLiteral(@"
        <style>

            table {
            font-family: arial, sans-serif;
            border-collapse: collapse;
            width: 100%;
            }

            td, th {
            border: 1px solid #dddddd;
            text-align: left;
            padding: 8px;
            }

            tr:nth-child(even) {
            background-color: #dddddd;
            }

            body {
            background-image:url('/images/maya1.jpg');
            height: 100%;
            width: 100%;
            background-size: auto;
            background-repeat: no-repeat;
            background-position: relative;
        
            }
        </style>
    <center>
    ");
            EndContext();
            BeginContext(730, 2535, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecb54373614642cb9f8b485a154eb535", async() => {
                BeginContext(736, 103, true);
                WriteLiteral("\n\n        <h2 style=\"color:#ffff4d\">Event Planner Center</h2> \n        <span style=\"color:red\">Welcome ");
                EndContext();
                BeginContext(840, 17, false);
#line 36 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
                                   Write(ViewBag.firstname);

#line default
#line hidden
                EndContext();
                BeginContext(857, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(859, 16, false);
#line 36 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
                                                      Write(ViewBag.lastname);

#line default
#line hidden
                EndContext();
                BeginContext(875, 554, true);
                WriteLiteral(@" !</span>
        
        <br><br>
        
        <a href=""/new""><button type=""button"" class=""btn btn-success"">Add New Activity!</button></a>
        | <a href=""/logout""><button  type=""button"" class=""btn btn-danger"">Log off</button></a>
        <hr>

        <table>
            <tr>
                <th>Event</th>
                <th>Date and Time</th>
                <th>Location</th>
                <th>Durantion</th>
                <th>Event Manager</th>
                <th>participants</th>
                <th>Actions</th>
            </tr>
");
                EndContext();
#line 54 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
              
                foreach (var w in @Model)
                {

#line default
#line hidden
                BeginContext(1504, 47, true);
                WriteLiteral("                <tr>\n                    <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1551, "\"", 1577, 2);
                WriteAttributeValue("", 1558, "/show/", 1558, 6, true);
#line 58 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
WriteAttributeValue("", 1564, w.ActivityId, 1564, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1578, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1580, 7, false);
#line 58 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
                                                 Write(w.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1587, 34, true);
                WriteLiteral("</a></td>\n                    <td>");
                EndContext();
                BeginContext(1622, 37, false);
#line 59 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
                   Write(w.Date.ToString("dddd, dd/MM/yyyy @"));

#line default
#line hidden
                EndContext();
                BeginContext(1659, 10, true);
                WriteLiteral(" <strong> ");
                EndContext();
                BeginContext(1670, 26, false);
#line 59 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
                                                                   Write(w.Time.ToShortTimeString());

#line default
#line hidden
                EndContext();
                BeginContext(1696, 55, true);
                WriteLiteral("</strong></td> \n                    <td><a target=\"new\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1751, "\"", 1859, 3);
                WriteAttributeValue("", 1758, "https://www.google.com/maps/embed/v1/search?q=", 1758, 46, true);
#line 60 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
WriteAttributeValue("", 1804, w.Location, 1804, 11, false);

#line default
#line hidden
                WriteAttributeValue("", 1815, "&key=AIzaSyDoztwQzwA4ReH0gj0fBFBmSRp0-AQ-B8E", 1815, 44, true);
                EndWriteAttribute();
                BeginContext(1860, 26, true);
                WriteLiteral(">\n                        ");
                EndContext();
                BeginContext(1887, 10, false);
#line 61 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
                   Write(w.Location);

#line default
#line hidden
                EndContext();
                BeginContext(1897, 35, true);
                WriteLiteral(" </a></td>\n                    <td>");
                EndContext();
                BeginContext(1933, 10, false);
#line 62 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
                   Write(w.Duration);

#line default
#line hidden
                EndContext();
                BeginContext(1943, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1945, 14, false);
#line 62 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
                               Write(w.DurationForm);

#line default
#line hidden
                EndContext();
                BeginContext(1959, 30, true);
                WriteLiteral("</td>\n                    <td>");
                EndContext();
                BeginContext(1990, 19, false);
#line 63 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
                   Write(w.Creator.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(2009, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2011, 18, false);
#line 63 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
                                        Write(w.Creator.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(2029, 31, true);
                WriteLiteral(" </td>\n                    <td>");
                EndContext();
                BeginContext(2061, 19, false);
#line 64 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
                   Write(w.participant.Count);

#line default
#line hidden
                EndContext();
                BeginContext(2080, 33, true);
                WriteLiteral("</td>\n\n                    <td> \n");
                EndContext();
#line 67 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
                          
                            var count =0;
                            foreach (var g in @w.participant)
                            {
                                if(@ViewBag.UserId == g.UserId)
                                {
                                    count++;
                                }
                            }
                        
                            if(count ==0)
                            {

#line default
#line hidden
                BeginContext(2578, 58, true);
                WriteLiteral("                                <a class=\"btn btn-success\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2636, "\"", 2662, 2);
                WriteAttributeValue("", 2643, "/rsvp/", 2643, 6, true);
#line 79 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
WriteAttributeValue("", 2649, w.ActivityId, 2649, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2663, 10, true);
                WriteLiteral(">Join</a>\n");
                EndContext();
#line 80 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
                            }
                            else
                            {

#line default
#line hidden
                BeginContext(2766, 57, true);
                WriteLiteral("                                <a class=\"btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2823, "\"", 2849, 2);
                WriteAttributeValue("", 2830, "/rsvp/", 2830, 6, true);
#line 83 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
WriteAttributeValue("", 2836, w.ActivityId, 2836, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2850, 11, true);
                WriteLiteral(">Leave</a>\n");
                EndContext();
#line 84 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
                            }
                        

#line default
#line hidden
                BeginContext(2917, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 86 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
                         if(@ViewBag.UserId == @w.UserId)
                        { 

#line default
#line hidden
                BeginContext(3002, 26, true);
                WriteLiteral("                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3028, "\"", 3059, 2);
                WriteAttributeValue("", 3035, "/deleteOne/", 3035, 11, true);
#line 88 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
WriteAttributeValue("", 3046, w.ActivityId, 3046, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3060, 15, true);
                WriteLiteral("> | Delete</a>\n");
                EndContext();
#line 89 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
                        }

#line default
#line hidden
                BeginContext(3101, 73, true);
                WriteLiteral("                    \n                    </td>\n                    </tr>\n");
                EndContext();
#line 93 "/Users/rabingora001/Desktop/codingDojo/c#/ASP.NET/Event_planner/Views/DojoActivity/Dashboard.cshtml"
                }
            

#line default
#line hidden
                BeginContext(3206, 52, true);
                WriteLiteral("                \n            </tr>\n        </table>\n");
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
            BeginContext(3265, 11, true);
            WriteLiteral("\n</center>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Activity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
