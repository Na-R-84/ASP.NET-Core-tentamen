#pragma checksum "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Shared\_CarouselSlide.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd114d247709891a4f54a4eb7b836e23fbce25ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FreakyFashion.Pages.Shared.Pages_Shared__CarouselSlide), @"mvc.1.0.view", @"/Pages/Shared/_CarouselSlide.cshtml")]
namespace FreakyFashion.Pages.Shared
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
#line 1 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\_ViewImports.cshtml"
using FreakyFashion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\_ViewImports.cshtml"
using FreakyFashion.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Shared\_CarouselSlide.cshtml"
using FreakyFashion.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd114d247709891a4f54a4eb7b836e23fbce25ae", @"/Pages/Shared/_CarouselSlide.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02fd40435331658698252967b4770e434015c281", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__CarouselSlide : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Shared\_CarouselSlide.cshtml"
  
    ViewData["Title"] = "Home page";
    
    bool IsFirstslide(Product product) 
        => product == Model.First();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"hero\" class=\"hero carousel slide\" data-ride=\"carousel\">\r\n    <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 12 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Shared\_CarouselSlide.cshtml"
         foreach (var product in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 358, "\"", 420, 2);
            WriteAttributeValue("", 366, "carousel-item", 366, 13, true);
#nullable restore
#line 14 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Shared\_CarouselSlide.cshtml"
WriteAttributeValue(" ", 379, IsFirstslide(product) ? "active" : "", 380, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"row h-25\" >\r\n                    <div class=\"col text-center \">\r\n                        <h2>");
#nullable restore
#line 17 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Shared\_CarouselSlide.cshtml"
                       Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p>");
#nullable restore
#line 18 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Shared\_CarouselSlide.cshtml"
                      Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 644, "\"", 671, 2);
            WriteAttributeValue("", 651, "/Product/", 651, 9, true);
#nullable restore
#line 19 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Shared\_CarouselSlide.cshtml"
WriteAttributeValue("", 660, product.Id, 660, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark  float-right\'\"> Show more</a>\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 819, "\"", 842, 1);
#nullable restore
#line 22 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Shared\_CarouselSlide.cshtml"
WriteAttributeValue("", 825, product.ImageUrl, 825, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                             class=\"d-block w-h-75\"");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 896, "\"", 945, 1);
#nullable restore
#line 24 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Shared\_CarouselSlide.cshtml"
WriteAttributeValue("", 932, product.Name, 932, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 28 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Shared\_CarouselSlide.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <a class=""carousel-control-prev"" href=""#hero"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only "">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#hero"" role=""button"" data-slide=""next"">
        <span class=""carousel- control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
