#pragma checksum "C:\Users\Razat\Desktop\NET\superking\Views\Home\Departments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43efd4dd7b3a0b729a44ec569f6531c29d9858f7"
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
#line 1 "C:\Users\Razat\Desktop\NET\superking\Views\_ViewImports.cshtml"
using mvcapp;

#line default
#line hidden
#line 2 "C:\Users\Razat\Desktop\NET\superking\Views\_ViewImports.cshtml"
using mvcapp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43efd4dd7b3a0b729a44ec569f6531c29d9858f7", @"/Views/Home/Departments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"950208d638fe40652455a86f77a4eb1be738d88d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Departments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Razat\Desktop\NET\superking\Views\Home\Departments.cshtml"
  
    ViewData["Title"] = "Department";

#line default
#line hidden
            BeginContext(46, 173, true);
            WriteLiteral("\r\n<style>\r\n    .text {\r\n        padding: 1rem;\r\n    }\r\n\r\n    .foodImg {\r\n        width: 100%; \r\n        height: 100%;\r\n    }\r\n</style>\r\n\r\n<h1 class=\"display-4 reddishColor\">");
            EndContext();
            BeginContext(220, 17, false);
#line 16 "C:\Users\Razat\Desktop\NET\superking\Views\Home\Departments.cshtml"
                              Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(237, 2100, true);
            WriteLiteral(@"</h1>

<!-- <div class=""row"">
    <div class=""col-md-4"">.col-md-4</div>
    <div class=""col-md-8"">.col-md-8</div>
</div> -->

<!-- https://www.c-sharpcorner.com/UploadFile/abhikumarvatsa/various-ways-to-pass-data-from-controller-to-view-in-mvc/
-->
<!-- Produce -->
<div class=""row border border-secondary rounded"" style = ""padding: 1rem 0rem;"">
    <div class=""col-lg-4"">
        <img src=""/img/departments/Produce-image.jpg"" alt=""mango"" title=""Produce"" class = ""foodImg"">
    </div>

    <div class=""col-lg-8 text"">
        <h4 title=""Produce"" class = ""reddishColor"">Produce</h4>
        <p><strong>Produce Palace!</strong>
        <br>When our customers think <strong>Super King</strong> the first thing that comes to mind is <strong>Produce</strong>.</p>
        <p>
            We guarantee fresh produce and the lowest prices every day. 
            Our produce variety includes strawberries, blueberries, avocados, 
            the largest variety of eggplant anywhere and even pomegranates.
  ");
            WriteLiteral(@"      </p>
    </div>
</div>

<!-- Meat -->
<div class=""row border border-secondary rounded"" style = ""padding: 1rem 0rem;"">
    <div class=""col-lg-8 text"">
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
        <img src=""/img/departments/meat-image.jpg"" alt=""mango"" ti");
            WriteLiteral("tle=\"Produce\" class = \"foodImg\">\r\n    </div>\r\n</div>");
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
