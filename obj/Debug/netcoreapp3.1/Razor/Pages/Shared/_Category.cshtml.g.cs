#pragma checksum "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Shared\_Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5894b304986ae52766ac2bdd395984738c08f4da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FreakyFashion.Pages.Shared.Pages_Shared__Category), @"mvc.1.0.view", @"/Pages/Shared/_Category.cshtml")]
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
#line 1 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Shared\_Category.cshtml"
using FreakyFashion.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5894b304986ae52766ac2bdd395984738c08f4da", @"/Pages/Shared/_Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02fd40435331658698252967b4770e434015c281", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Shared\_Category.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <h2 class=\"text-center\">Categories</h2>\r\n    <div class=\"row h-25 \">\r\n\r\n");
#nullable restore
#line 10 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Shared\_Category.cshtml"
         foreach (var category in Model.Take(3))
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col w-25\">\r\n\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 324, "\"", 353, 2);
            WriteAttributeValue("", 331, "/Category/", 331, 10, true);
#nullable restore
#line 15 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Shared\_Category.cshtml"
WriteAttributeValue("", 341, category.Id, 341, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 359, "\"", 383, 1);
#nullable restore
#line 15 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Shared\_Category.cshtml"
WriteAttributeValue("", 365, category.ImageUrl, 365, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /> </a>\r\n\r\n            </div>\r\n");
#nullable restore
#line 18 "C:\Ec utbildning\asp.netcore\FreakyFashion\Pages\Shared\_Category.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
