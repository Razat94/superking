#pragma checksum "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\Departments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75b55b7802adfeff88d073bcbb49f7004651c587"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Departments), @"mvc.1.0.view", @"/Views/Home/Departments.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Departments.cshtml", typeof(AspNetCore.Views_Home_Departments))]
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
#line 1 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\Departments.cshtml"
using departmentPage.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75b55b7802adfeff88d073bcbb49f7004651c587", @"/Views/Home/Departments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"950208d638fe40652455a86f77a4eb1be738d88d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Departments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\Departments.cshtml"
  
    DepartmentList list = ViewBag.dpList;

#line default
#line hidden
            BeginContext(83, 63, true);
            WriteLiteral("\r\n<style>\r\n   \r\n</style>\r\n\r\n<h1 class=\"display-4 reddishColor\">");
            EndContext();
            BeginContext(147, 17, false);
#line 11 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\Departments.cshtml"
                              Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(164, 148, true);
            WriteLiteral("</h1>\r\n\r\n<!-- <div class=\"row\">\r\n    <div class=\"col-md-4\">.col-md-4</div>\r\n    <div class=\"col-md-8\">.col-md-8</div>\r\n</div> -->\r\n\r\n<!-- List -->\r\n");
            EndContext();
#line 19 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\Departments.cshtml"
 for(var i = 0; i < @list.dList.Count; i++) {

#line default
#line hidden
            BeginContext(359, 85, true);
            WriteLiteral("    <div class=\"row border border-secondary rounded\" style = \"padding: 1rem 0rem;\">\r\n");
            EndContext();
#line 21 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\Departments.cshtml"
         if ( i == 0 || i % 2 == 0 ) {

#line default
#line hidden
            BeginContext(484, 62, true);
            WriteLiteral("            <div class=\"col-lg-4\">\r\n                <img src= ");
            EndContext();
            BeginContext(547, 20, false);
#line 23 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\Departments.cshtml"
                     Write(list.dList[i].imgSrc);

#line default
#line hidden
            EndContext();
            BeginContext(567, 41, true);
            WriteLiteral(" class = \"foodImg\">\r\n            </div>\r\n");
            EndContext();
#line 25 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\Departments.cshtml"
        }

#line default
#line hidden
            BeginContext(619, 106, true);
            WriteLiteral("\r\n        <div class=\"col-lg-8 text\">\r\n            <h4 title=\"\" class = \"reddishColor\"> \r\n                ");
            EndContext();
            BeginContext(726, 19, false);
#line 29 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\Departments.cshtml"
           Write(list.dList[i].title);

#line default
#line hidden
            EndContext();
            BeginContext(745, 62, true);
            WriteLiteral("\r\n            </h4>\r\n            <p>\r\n                <strong>");
            EndContext();
            BeginContext(808, 22, false);
#line 32 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\Departments.cshtml"
                   Write(list.dList[i].subtitle);

#line default
#line hidden
            EndContext();
            BeginContext(830, 49, true);
            WriteLiteral("</strong>\r\n                <br>\r\n                ");
            EndContext();
            BeginContext(880, 16, false);
#line 34 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\Departments.cshtml"
           Write(list.dList[i].p1);

#line default
#line hidden
            EndContext();
            BeginContext(896, 53, true);
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(950, 16, false);
#line 37 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\Departments.cshtml"
           Write(list.dList[i].p2);

#line default
#line hidden
            EndContext();
            BeginContext(966, 108, true);
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n\r\n        <!-- Odd Numbered Images of Index 1, 3, 5 will show here -->\r\n");
            EndContext();
#line 42 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\Departments.cshtml"
         if ( i > 0 && i % 2 != 0 ) {

#line default
#line hidden
            BeginContext(1113, 62, true);
            WriteLiteral("            <div class=\"col-lg-4\">\r\n                <img src= ");
            EndContext();
            BeginContext(1176, 20, false);
#line 44 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\Departments.cshtml"
                     Write(list.dList[i].imgSrc);

#line default
#line hidden
            EndContext();
            BeginContext(1196, 41, true);
            WriteLiteral(" class = \"foodImg\">\r\n            </div>\r\n");
            EndContext();
#line 46 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\Departments.cshtml"
        }

#line default
#line hidden
            BeginContext(1248, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 48 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\Departments.cshtml"
}

#line default
#line hidden
            BeginContext(1263, 1997, true);
            WriteLiteral(@"
<!-- https://www.c-sharpcorner.com/UploadFile/abhikumarvatsa/various-ways-to-pass-data-from-controller-to-view-in-mvc/
-->
<!-- 
<div class=""row border border-secondary rounded"" style = ""padding: 1rem 0rem;"">
    <div class=""col-lg-4"">
        <img src=""/img/departments/1)Produce-image.jpg"" alt=""mango"" title=""Produce"" class = ""foodImg"">
    </div>

    <div class=""col-lg-8 text"">
        <h4 title=""Produce"" class = ""reddishColor"">Produce</h4>
        <p><strong>Produce Palace!</strong>
        <br>When our customers think <strong>Super King</strong> the first thing that comes to mind is <strong>Produce</strong>.</p>
        <p>
            We guarantee fresh produce and the lowest prices every day. 
            Our produce variety includes strawberries, blueberries, avocados, 
            the largest variety of eggplant anywhere and even pomegranates.
        </p>
    </div>
</div>

<div class=""row border border-secondary rounded"" style = ""padding: 1rem 0rem;"">
    <div class=""col-lg-8 ");
            WriteLiteral(@"text"">
        <h4 title=""Meat &amp; Seafood"" class = ""reddishColor"">Meat &amp; Seafood</h4>
        <p>
            Our friendly butchers have years of experience and can always meet your needs.
            If you're on the move, our <strong>meats</strong> are also 
            individually <strong>packaged</strong> and ready to go.</p>
            <p>Our meat is delivered daily and always guaranteed fresh or your money back. 
            If you are looking for a special cut or grade, 
            feel free to ask us and we can order it for you. 
            Fresh and premium quality seafood is what Super King takes pride in. 
            Whether it is cooked or raw shrimp, fresh fillets, whole fish or crab meat, we carry it!
        </p>
    </div>

    <div class=""col-lg-4"">
        <img src=""/img/departments/2)meat-image.jpg"" alt=""mango"" title=""Produce"" class = ""foodImg"">
    </div>
</div>

<p id = ""redfont"">
    HELLO WORLD
</p>
-->");
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
