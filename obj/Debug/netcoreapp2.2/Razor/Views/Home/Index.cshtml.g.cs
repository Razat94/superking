#pragma checksum "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d1429393671b61f86e333683bbdb99135ceb912"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d1429393671b61f86e333683bbdb99135ceb912", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"950208d638fe40652455a86f77a4eb1be738d88d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background: white; width: 30%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "aboutUs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Razat\Desktop\Projects\Github Projects\superking\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.contactUs.cshtml";

#line default
#line hidden
            BeginContext(102, 502, true);
            WriteLiteral(@"
<div class=""jumbotron"" style = ""background: linear-gradient(45deg,#dd3d31 0%,#d22f23 100%); margin-bottom: 0rem;"">
	<div class=""container"">
		<center>
		<h1 class=""display-3 text-white"">Welcome to Superking Markets!</h1>
		<p class = ""text-white"">Enjoy more international products for a lot less!</p>

		<!-- <button type=""button"" class=""btn btn-raised btn-sm rounded"" style = ""background: white; color: #dd3d31"" asp-controller=""Home"" asp-action=""aboutUs"">
			Learn More
		</button> -->

		");
            EndContext();
            BeginContext(604, 194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d1429393671b61f86e333683bbdb99135ceb9125551", async() => {
                BeginContext(738, 56, true);
                WriteLiteral("\r\n\t\t\t<span style = \"color: #dd3d31;\">About Us</span>\r\n\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(798, 1943, true);
            WriteLiteral(@"		
		<!-- <a class=""btn btn-outline-secondary"" href=""#"">Coming soon</a> -->
		</center>
	</div>
</div>

<!-- 
<div class=""container-fluid"">
  <div class=""d-flex flex-row flex-wrap justify-content-center"">
    <div class=""d-flex flex-column"">
        <img src=""/img/departments/Produce-image.jpg"" class=""img-fluid"">
        
        <img src=""/img/departments/Produce-image.jpg"" class=""img-fluid"">
    </div>
        
    <div class=""d-flex flex-column"">
        <img src=""/img/departments/Produce-image.jpg"" class=""img-fluid"">
        
        <img src=""/img/departments/Produce-image.jpg"" class=""img-fluid scale"">
    </div>
    
    <div class=""d-flex flex-column"">
        <img src=""/img/departments/Produce-image.jpg"" class=""img-fluid scale mb-2"">
        <img src=""/img/departments/Produce-image.jpg""  class=""img-fluid"">
    </div>
    
    <div class=""d-flex flex-column"">
        <img src=""/img/departments/Produce-image.jpg"" class=""img-fluid m-1 p-1"">
          <img src=""/img/departments");
            WriteLiteral(@"/Produce-image.jpg"" class=""img-fluid image m-1 p-1"">
    </div>
  </div>
</div>
-->

<div class=""card-columns container"" style = ""margin-top: 1rem;"">
  <div class=""card"">
    <img class=""card-img-top"" src=""/img/departments/1)Produce-image.jpg"" alt=""Card image cap"">
  </div>

  <div class=""card"">
    <img class=""card-img-top"" src=""/img/departments/2)Meat-image.jpg"" alt=""Card image cap"">
  </div>
  
  <div class=""card"">
    <img class=""card-img"" src=""/img/departments/3)Groceries-image.jpg"" alt=""Card image"">
  </div>

  <div class=""card"">
    <img class=""card-img"" src=""/img/departments/4)Service-deli-image.jpg"" alt=""Card image"">
  </div>

  <div class=""card"">
    <img class=""card-img"" src=""/img/departments/5)bakery-image.jpg"" alt=""Card image"">
  </div>

  <div class=""card"">
    <img class=""card-img"" src=""/img/departments/6)mixed-nuts-image.jpg"" alt=""Card image"">
  </div>

</div>");
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
