#pragma checksum "/Users/shanizalingle/Desktop/projects/c#/car-dealership/Views/Cars/Cars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3b8a9db7e50cde12345999964588a7e3aa2797e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Cars), @"mvc.1.0.view", @"/Views/Cars/Cars.cshtml")]
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
#line 9 "/Users/shanizalingle/Desktop/projects/c#/car-dealership/Views/Cars/Cars.cshtml"
using Dealership.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3b8a9db7e50cde12345999964588a7e3aa2797e", @"/Views/Cars/Cars.cshtml")]
    public class Views_Cars_Cars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html>\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3b8a9db7e50cde12345999964588a7e3aa2797e2835", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>Car Dealership</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk"" crossorigin=""anonymous"">
  ");
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
            WriteLiteral("\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3b8a9db7e50cde12345999964588a7e3aa2797e4074", async() => {
                WriteLiteral("\n");
                WriteLiteral("\t\t<h1>Here\'s list of our cars:</h1>\n\t\t<!-- <a href=\'/cars/new\'> Sell your!</a>\n\t\t<a href=\'/cars\'> See list of cars we got!</a> -->\n\t\t\n");
#nullable restore
#line 14 "/Users/shanizalingle/Desktop/projects/c#/car-dealership/Views/Cars/Cars.cshtml"
         if (Model.Count == 0)
		{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t<p> No cars currently available. </p>\n");
#nullable restore
#line 17 "/Users/shanizalingle/Desktop/projects/c#/car-dealership/Views/Cars/Cars.cshtml"
		} else {

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t<ul>\n");
#nullable restore
#line 19 "/Users/shanizalingle/Desktop/projects/c#/car-dealership/Views/Cars/Cars.cshtml"
             foreach(Car car in Model)
			{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t<li> Makemodel of car is: ");
#nullable restore
#line 21 "/Users/shanizalingle/Desktop/projects/c#/car-dealership/Views/Cars/Cars.cshtml"
                                     Write(car.MakeModel);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </li>\n");
#nullable restore
#line 22 "/Users/shanizalingle/Desktop/projects/c#/car-dealership/Views/Cars/Cars.cshtml"
			}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t</ul>\n");
#nullable restore
#line 24 "/Users/shanizalingle/Desktop/projects/c#/car-dealership/Views/Cars/Cars.cshtml"
		}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\n\t\t<a href=\'/cars/new\'> Add another car! </a>\n\n  ");
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
            WriteLiteral("\n</html>");
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
