#pragma checksum "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a3802a5ee56483f95273cc25392abb022474849"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructors_Index), @"mvc.1.0.view", @"/Views/Instructors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Instructors/Index.cshtml", typeof(AspNetCore.Views_Instructors_Index))]
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
#line 1 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\_ViewImports.cshtml"
using ContosoUniversity;

#line default
#line hidden
#line 2 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\_ViewImports.cshtml"
using ContosoUniversity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3802a5ee56483f95273cc25392abb022474849", @"/Views/Instructors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd4358eedcd619245030e2e2b4d3f06dd6511943", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContosoUniversity.Models.SchoolViewModels.InstructorIndexData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(69, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
  
    ViewData["Title"] = "Instructors";

#line default
#line hidden
            BeginContext(114, 31, true);
            WriteLiteral("\n<h2>Instructors</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(145, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ed96370d4964a37962a18608a252948", async() => {
                BeginContext(168, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(182, 248, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>Last Name</th>\n            <th>First Name</th>\n            <th>Hire Date</th>\n            <th>Office</th>\n            <th>Courses</th>\n        </tr>\n    </thead>\n        <tbody >\n");
            EndContext();
#line 23 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
             foreach (var item in Model.Instructors)
            {
                string selectedRow = "";
                if (item.Id == (int?)ViewData["InstructorId"])                 
                {
                    selectedRow = "success";
                }

#line default
#line hidden
            BeginContext(699, 19, true);
            WriteLiteral("                <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 718, "\"", 738, 1);
#line 30 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
WriteAttributeValue("", 726, selectedRow, 726, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(739, 51, true);
            WriteLiteral(">\n                    <td>\n                        ");
            EndContext();
            BeginContext(791, 43, false);
#line 32 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(834, 76, true);
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(911, 47, false);
#line 35 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FirstMidName));

#line default
#line hidden
            EndContext();
            BeginContext(958, 76, true);
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(1035, 43, false);
#line 38 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1078, 52, true);
            WriteLiteral("\n                    </td>\n                    <td>\n");
            EndContext();
#line 41 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
                         if (item.OfficeAssignment != null)
                        {
                            

#line default
#line hidden
            BeginContext(1245, 30, false);
#line 43 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
                       Write(item.OfficeAssignment.Location);

#line default
#line hidden
            EndContext();
#line 43 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
                                                           
                        }

#line default
#line hidden
            BeginContext(1302, 51, true);
            WriteLiteral("                    </td>\n                    <td>\n");
            EndContext();
#line 47 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
                           
                            foreach (var course in item.CourseAssignments)
                            {
                                

#line default
#line hidden
            BeginContext(1519, 22, false);
#line 50 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
                           Write(course.Course.CourseId);

#line default
#line hidden
            EndContext();
            BeginContext(1541, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1544, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1546, 19, false);
#line 50 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
                                                      Write(course.Course.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1565, 8, true);
            WriteLiteral("  <br/>\n");
            EndContext();
#line 51 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(1629, 75, true);
            WriteLiteral("                    </td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(1704, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45106396bfeb4f27ab8583ec92d8e745", async() => {
                BeginContext(1750, 6, true);
                WriteLiteral("Select");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
                                                WriteLiteral(item.Id);

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
            BeginContext(1760, 27, true);
            WriteLiteral(" |\n                        ");
            EndContext();
            BeginContext(1787, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70c9900a23074c2da1c928e7a64328f1", async() => {
                BeginContext(1832, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
                                               WriteLiteral(item.Id);

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
            BeginContext(1840, 27, true);
            WriteLiteral(" |\n                        ");
            EndContext();
            BeginContext(1867, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "840ab066049a456c9be1558890c09c9c", async() => {
                BeginContext(1915, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
                                                  WriteLiteral(item.Id);

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
            BeginContext(1926, 27, true);
            WriteLiteral(" |\n                        ");
            EndContext();
            BeginContext(1953, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a0c059ec97645db9721aa3b49a2fda9", async() => {
                BeginContext(2000, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
                                                 WriteLiteral(item.Id);

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
            BeginContext(2010, 49, true);
            WriteLiteral("\n                    </td>\n                </tr>\n");
            EndContext();
#line 61 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
             }

#line default
#line hidden
            BeginContext(2074, 23, true);
            WriteLiteral("    </tbody>\n</table>\n\n");
            EndContext();
#line 65 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
 if (Model.Courses != null)
{

#line default
#line hidden
            BeginContext(2127, 213, true);
            WriteLiteral("    <h3>Courses Taught by Selected Instructor</h3>\n    <table class=\"table\">\n        <tr>\n            <th></th>\n            <th>Number</th>\n            <th>Title</th>\n            <th>Department</th>\n        </tr>\n");
            EndContext();
#line 75 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
         foreach (var item in Model.Courses)
        {
            string selectedRow = "";
            if (item.CourseId == (int?)ViewData["CourseId"])
            {
                selectedRow = "success";
            }

#line default
#line hidden
            BeginContext(2562, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2577, "\"", 2597, 1);
#line 82 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
WriteAttributeValue("", 2585, selectedRow, 2585, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2598, 43, true);
            WriteLiteral(">\n                <td>\n                    ");
            EndContext();
            BeginContext(2642, 66, false);
#line 84 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
               Write(Html.ActionLink("Select", "Index", new {courseId = item.CourseId}));

#line default
#line hidden
            EndContext();
            BeginContext(2708, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2773, 13, false);
#line 87 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
               Write(item.CourseId);

#line default
#line hidden
            EndContext();
            BeginContext(2786, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2851, 10, false);
#line 90 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2861, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2926, 20, false);
#line 93 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
               Write(item.Department.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2946, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 96 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2997, 13, true);
            WriteLiteral("    </table>\n");
            EndContext();
#line 98 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3012, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 100 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
 if (Model.Enrollments != null)
{

#line default
#line hidden
            BeginContext(3047, 170, true);
            WriteLiteral("    <h3>\n        Students Enrolled in Selected Course\n    </h3>\n    <table class=\"table\">\n        <tr>\n            <th>Name</th>\n            <th>Grade</th>\n        </tr>\n");
            EndContext();
#line 110 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
         foreach (var item in Model.Enrollments)
        {

#line default
#line hidden
            BeginContext(3276, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(3335, 21, false);
#line 114 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
               Write(item.Student.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(3356, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(3421, 40, false);
#line 117 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Grade));

#line default
#line hidden
            EndContext();
            BeginContext(3461, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 120 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3512, 13, true);
            WriteLiteral("    </table>\n");
            EndContext();
#line 122 "C:\Users\vitos\Documents\ASP\EFCoreAsp.NetMvcWebApp\ContosoUniversity009\Views\Instructors\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContosoUniversity.Models.SchoolViewModels.InstructorIndexData> Html { get; private set; }
    }
}
#pragma warning restore 1591
