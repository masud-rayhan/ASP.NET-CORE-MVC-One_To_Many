#pragma checksum "F:\ASP.NET CORE\ASP_NET_CORE_ONE_TO_MANY_CRUD\ASP_NET_CORE_ONE_TO_MANY_CRUD\Views\Student\StudentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cde652a9d146755108e9f8059c4c6e6c32d9bf95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_StudentList), @"mvc.1.0.view", @"/Views/Student/StudentList.cshtml")]
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
#line 1 "F:\ASP.NET CORE\ASP_NET_CORE_ONE_TO_MANY_CRUD\ASP_NET_CORE_ONE_TO_MANY_CRUD\Views\_ViewImports.cshtml"
using ASP_NET_CORE_ONE_TO_MANY_CRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ASP.NET CORE\ASP_NET_CORE_ONE_TO_MANY_CRUD\ASP_NET_CORE_ONE_TO_MANY_CRUD\Views\_ViewImports.cshtml"
using ASP_NET_CORE_ONE_TO_MANY_CRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cde652a9d146755108e9f8059c4c6e6c32d9bf95", @"/Views/Student/StudentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6f4d74c0e81d8647f0356d12cfd7b15593c9125", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_StudentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASP_NET_CORE_ONE_TO_MANY_CRUD.Models.Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "F:\ASP.NET CORE\ASP_NET_CORE_ONE_TO_MANY_CRUD\ASP_NET_CORE_ONE_TO_MANY_CRUD\Views\Student\StudentList.cshtml"
  
    ViewData["Title"] = "StudentList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-8\">\r\n            <h2>Student List</h2>\r\n        </div>\r\n        <div class=\"col-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cde652a9d146755108e9f8059c4c6e6c32d9bf954388", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <table class=\"table table-striped\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 23 "F:\ASP.NET CORE\ASP_NET_CORE_ONE_TO_MANY_CRUD\ASP_NET_CORE_ONE_TO_MANY_CRUD\Views\Student\StudentList.cshtml"
                       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 26 "F:\ASP.NET CORE\ASP_NET_CORE_ONE_TO_MANY_CRUD\ASP_NET_CORE_ONE_TO_MANY_CRUD\Views\Student\StudentList.cshtml"
                       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 29 "F:\ASP.NET CORE\ASP_NET_CORE_ONE_TO_MANY_CRUD\ASP_NET_CORE_ONE_TO_MANY_CRUD\Views\Student\StudentList.cshtml"
                       Write(Html.DisplayNameFor(model => model.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 32 "F:\ASP.NET CORE\ASP_NET_CORE_ONE_TO_MANY_CRUD\ASP_NET_CORE_ONE_TO_MANY_CRUD\Views\Student\StudentList.cshtml"
                       Write(Html.DisplayNameFor(model => model.DepId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 35 "F:\ASP.NET CORE\ASP_NET_CORE_ONE_TO_MANY_CRUD\ASP_NET_CORE_ONE_TO_MANY_CRUD\Views\Student\StudentList.cshtml"
                       Write(Html.DisplayNameFor(model => model.Department.DepName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 38 "F:\ASP.NET CORE\ASP_NET_CORE_ONE_TO_MANY_CRUD\ASP_NET_CORE_ONE_TO_MANY_CRUD\Views\Student\StudentList.cshtml"
                       Write(Html.DisplayNameFor(model => model.Department.DepChairman));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n\r\n                <tbody>\r\n");
#nullable restore
#line 47 "F:\ASP.NET CORE\ASP_NET_CORE_ONE_TO_MANY_CRUD\ASP_NET_CORE_ONE_TO_MANY_CRUD\Views\Student\StudentList.cshtml"
                     foreach(var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 51 "F:\ASP.NET CORE\ASP_NET_CORE_ONE_TO_MANY_CRUD\ASP_NET_CORE_ONE_TO_MANY_CRUD\Views\Student\StudentList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 54 "F:\ASP.NET CORE\ASP_NET_CORE_ONE_TO_MANY_CRUD\ASP_NET_CORE_ONE_TO_MANY_CRUD\Views\Student\StudentList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 57 "F:\ASP.NET CORE\ASP_NET_CORE_ONE_TO_MANY_CRUD\ASP_NET_CORE_ONE_TO_MANY_CRUD\Views\Student\StudentList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 60 "F:\ASP.NET CORE\ASP_NET_CORE_ONE_TO_MANY_CRUD\ASP_NET_CORE_ONE_TO_MANY_CRUD\Views\Student\StudentList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DepId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 63 "F:\ASP.NET CORE\ASP_NET_CORE_ONE_TO_MANY_CRUD\ASP_NET_CORE_ONE_TO_MANY_CRUD\Views\Student\StudentList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Department.DepName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 66 "F:\ASP.NET CORE\ASP_NET_CORE_ONE_TO_MANY_CRUD\ASP_NET_CORE_ONE_TO_MANY_CRUD\Views\Student\StudentList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Department.DepChairman));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 69 "F:\ASP.NET CORE\ASP_NET_CORE_ONE_TO_MANY_CRUD\ASP_NET_CORE_ONE_TO_MANY_CRUD\Views\Student\StudentList.cshtml"
                       Write(Html.ActionLink("Edit", "Create", new { id=item.ID ,item.Name,item.Email, item.Mobile,item.DepId }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                            ");
#nullable restore
#line 70 "F:\ASP.NET CORE\ASP_NET_CORE_ONE_TO_MANY_CRUD\ASP_NET_CORE_ONE_TO_MANY_CRUD\Views\Student\StudentList.cshtml"
                       Write(Html.ActionLink("Delete", "DeleteStd", new { id = item.ID }, new { @class = "btn btn-danger" , onclick="return confirm(''Do you want to delete')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 75 "F:\ASP.NET CORE\ASP_NET_CORE_ONE_TO_MANY_CRUD\ASP_NET_CORE_ONE_TO_MANY_CRUD\Views\Student\StudentList.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASP_NET_CORE_ONE_TO_MANY_CRUD.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
