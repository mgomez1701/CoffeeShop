#pragma checksum "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\CSharp_October2019\CoffeeShopLab\CoffeeShopLab\CoffeeShopLab\Views\NewUser\NewUserSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e47c162c398bfe4da3d83d7d0b6f633858efa05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewUser_NewUserSummary), @"mvc.1.0.view", @"/Views/NewUser/NewUserSummary.cshtml")]
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
#line 1 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\CSharp_October2019\CoffeeShopLab\CoffeeShopLab\CoffeeShopLab\Views\_ViewImports.cshtml"
using CoffeeShopLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\CSharp_October2019\CoffeeShopLab\CoffeeShopLab\CoffeeShopLab\Views\_ViewImports.cshtml"
using CoffeeShopLab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e47c162c398bfe4da3d83d7d0b6f633858efa05", @"/Views/NewUser/NewUserSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a42c833882c183b4c6a5cbc24b5111b803deaf38", @"/Views/_ViewImports.cshtml")]
    public class Views_NewUser_NewUserSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoffeeShopLab.Models.NewUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\CSharp_October2019\CoffeeShopLab\CoffeeShopLab\CoffeeShopLab\Views\NewUser\NewUserSummary.cshtml"
  
    ViewData["Title"] = "NewUserSummary";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Welcome! Please Review & Confirm:</h1>\r\n\r\n<h3>Username:</h3> <p>");
#nullable restore
#line 10 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\CSharp_October2019\CoffeeShopLab\CoffeeShopLab\CoffeeShopLab\Views\NewUser\NewUserSummary.cshtml"
                 Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<h3>Email:</h3> <p>");
#nullable restore
#line 11 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\CSharp_October2019\CoffeeShopLab\CoffeeShopLab\CoffeeShopLab\Views\NewUser\NewUserSummary.cshtml"
              Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<h3>Password:</h3> <p>");
#nullable restore
#line 12 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\CSharp_October2019\CoffeeShopLab\CoffeeShopLab\CoffeeShopLab\Views\NewUser\NewUserSummary.cshtml"
                 Write(Model.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoffeeShopLab.Models.NewUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
