#pragma checksum "C:\Users\1\source\repos\AutoShop\AutoShop\Views\Cars\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bb69ed4080ce383c6be2a37c6f5e6262d59c13a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_List), @"mvc.1.0.view", @"/Views/Cars/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/List.cshtml", typeof(AspNetCore.Views_Cars_List))]
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
#line 1 "C:\Users\1\source\repos\AutoShop\AutoShop\Views\_ViewImports.cshtml"
using AutoShop.ViewModels.AutoShopCartVM;

#line default
#line hidden
#line 2 "C:\Users\1\source\repos\AutoShop\AutoShop\Views\_ViewImports.cshtml"
using AutoShop.ViewModels.CarsVM;

#line default
#line hidden
#line 3 "C:\Users\1\source\repos\AutoShop\AutoShop\Views\_ViewImports.cshtml"
using AutoShop.ViewModels.HomeVM;

#line default
#line hidden
#line 4 "C:\Users\1\source\repos\AutoShop\AutoShop\Views\_ViewImports.cshtml"
using AutoShop.ViewModels.OrderVM;

#line default
#line hidden
#line 6 "C:\Users\1\source\repos\AutoShop\AutoShop\Views\_ViewImports.cshtml"
using DataLayer.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bb69ed4080ce383c6be2a37c6f5e6262d59c13a", @"/Views/Cars/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eb9c2f7bfc804a7c1d556dc89e093806552165a", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 29, true);
            WriteLiteral("<h1>Все автомобили</h1>\r\n<h3>");
            EndContext();
            BeginContext(30, 17, false);
#line 2 "C:\Users\1\source\repos\AutoShop\AutoShop\Views\Cars\List.cshtml"
Write(Model.CarCategory);

#line default
#line hidden
            EndContext();
            BeginContext(47, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 3 "C:\Users\1\source\repos\AutoShop\AutoShop\Views\Cars\List.cshtml"
  
    foreach (Car car in Model.AllCars)
    {
        

#line default
#line hidden
            BeginContext(114, 28, false);
#line 6 "C:\Users\1\source\repos\AutoShop\AutoShop\Views\Cars\List.cshtml"
   Write(Html.Partial("AllCars", car));

#line default
#line hidden
            EndContext();
#line 6 "C:\Users\1\source\repos\AutoShop\AutoShop\Views\Cars\List.cshtml"
                                     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
