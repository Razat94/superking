#pragma checksum "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\employee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "184e6a5ad0f00b4d313e15c15f69cf01af6b9b78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_employee), @"mvc.1.0.view", @"/Views/Home/employee.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/employee.cshtml", typeof(AspNetCore.Views_Home_employee))]
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
#line 1 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\_ViewImports.cshtml"
using mvcapp;

#line default
#line hidden
#line 2 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\_ViewImports.cshtml"
using mvcapp.Models;

#line default
#line hidden
#line 1 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\employee.cshtml"
using employeePage.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"184e6a5ad0f00b4d313e15c15f69cf01af6b9b78", @"/Views/Home/employee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"950208d638fe40652455a86f77a4eb1be738d88d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_employee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\employee.cshtml"
  
    ViewData["Title"] = "Employees";
    EmployeeList list = ViewBag.employeesOfTheMonth;

#line default
#line hidden
            BeginContext(130, 169, true);
            WriteLiteral("\r\n<link href=\'https://fonts.googleapis.com/css?family=Roboto\' rel=\'stylesheet\'>\r\n\r\n<section class = \"px3\">\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">");
            EndContext();
            BeginContext(300, 17, false);
#line 12 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\employee.cshtml"
                         Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(317, 296, true);
            WriteLiteral(@"</h1>
    </div>

    <!-- Automatically assumes that parent folder is wwwroot -->
    <a href = ""..\xml\test.xml"" style = ""display: block; margin: auto; text-align: center;"">
        <button> View XML file here </button>
    </a> 
    <div class=""container px3"">
        
            
");
            EndContext();
#line 22 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\employee.cshtml"
             for(var i = 0; i < @list.employeeList.Count; i++) {

#line default
#line hidden
            BeginContext(679, 205, true);
            WriteLiteral("                <div class=\"row\" style = \"margin: 1rem auto;\">\r\n                    <div class=\"col-lg-8 text\"> \r\n                        <h4 title=\"\" class = \"reddishColor\"> \r\n                            ");
            EndContext();
            BeginContext(885, 25, false);
#line 26 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\employee.cshtml"
                       Write(list.employeeList[i].name);

#line default
#line hidden
            EndContext();
            BeginContext(910, 124, true);
            WriteLiteral("\r\n                        </h4>\r\n                        \r\n                        <p>\r\n                            <strong>");
            EndContext();
            BeginContext(1035, 34, false);
#line 30 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\employee.cshtml"
                               Write(list.employeeList[i].personalQuote);

#line default
#line hidden
            EndContext();
            BeginContext(1069, 73, true);
            WriteLiteral("</strong>\r\n                            <br>\r\n                            ");
            EndContext();
            BeginContext(1143, 32, false);
#line 32 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\employee.cshtml"
                       Write(list.employeeList[i].description);

#line default
#line hidden
            EndContext();
            BeginContext(1175, 138, true);
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                    <div class=\"col-lg-4\">\r\n                        <img src= ");
            EndContext();
            BeginContext(1314, 27, false);
#line 36 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\employee.cshtml"
                             Write(list.employeeList[i].imgSrc);

#line default
#line hidden
            EndContext();
            BeginContext(1341, 79, true);
            WriteLiteral(" class = \"employeeImg\" />\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 39 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\employee.cshtml"
            }

#line default
#line hidden
            BeginContext(1435, 34, true);
            WriteLiteral("\r\n        \r\n    </div>\r\n</section>");
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