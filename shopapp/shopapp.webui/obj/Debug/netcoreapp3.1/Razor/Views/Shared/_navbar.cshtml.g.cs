#pragma checksum "C:\Users\User\Desktop\Memo\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75acd231e396161d06262923ee805b13a1a6034a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__navbar), @"mvc.1.0.view", @"/Views/Shared/_navbar.cshtml")]
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
#line 2 "C:\Users\User\Desktop\Memo\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Memo\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Memo\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Memo\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\Memo\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\Memo\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75acd231e396161d06262923ee805b13a1a6034a", @"/Views/Shared/_navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a37584fdbe64ca31cd20fae569eeb6d30eee5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""navbar bg-dark navbar-dark navbar-expand-sm"">



    <div class=""container"">
        <a href=""/"" class=""navbar-brand""><i class=""fas fa-store-alt fa-2x""></i></a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent""
            aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>

        <ul class=""navbar-nav mr-auto"">

");
#nullable restore
#line 14 "C:\Users\User\Desktop\Memo\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
             if (User.Identity.IsAuthenticated)
            {
               
                if (User.IsInRole("admin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <li class=""nav-item"">
                        <a href=""/admin/products"" class=""nav-link"">Ürünler</a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/admin/categories"" class=""nav-link"">Kategoriler</a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/admin/role/list"" class=""nav-link"">Roller</a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/admin/user/list"" class=""nav-link"">Kullanıcılar</a>
                    </li>
");
#nullable restore
#line 31 "C:\Users\User\Desktop\Memo\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n\r\n    <ul class=\"navbar-nav ml-auto\">\r\n\r\n");
#nullable restore
#line 38 "C:\Users\User\Desktop\Memo\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
         if (User.Identity.IsAuthenticated)
        {

            if (User.IsInRole("Customer"))
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-item\">\r\n                    <a href=\"/cart\" class=\"nav-link\"><i class=\"fas fa-shopping-basket fa-2x\" style=\"color: white;\"></i></a>\r\n                </li>\r\n");
            WriteLiteral(@"            <li class=""nav-item dropdown"">
                <a class=""nav-link dropdown-toggle pt-3 px-3"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown""
                    aria-haspopup=""true"" aria-expanded=""false"">
                    <i class=""fas fa-user-tie""></i>&nbsp ");
#nullable restore
#line 53 "C:\Users\User\Desktop\Memo\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
                                                    Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </a>
                <div class=""dropdown-menu"" aria-labelledby=""navbarDropdownMenuLink"">
                    <a class=""dropdown-item"" href=""/cart"">Sepetim</a>
                    <a class=""dropdown-item"" href=""/orders"">Geçmiş</a>
                    <div class=""dropdown-divider""></div>
                </div>
            </li>
");
#nullable restore
#line 61 "C:\Users\User\Desktop\Memo\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
             }
             

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\User\Desktop\Memo\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
              if (User.IsInRole("admin"))
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <li class=\"nav-item\">\r\n                    <a href=\"/\" class=\"nav-link\"><i class=\"fas fa-user-tie\"></i>&nbsp ");
#nullable restore
#line 65 "C:\Users\User\Desktop\Memo\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
                                                                                 Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n");
#nullable restore
#line 67 "C:\Users\User\Desktop\Memo\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
                 
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"nav-item\" style=\"float: inline-end;\">\r\n                <a href=\"/account/logout\" class=\"nav-link\"><i class=\"fas fa-sign-out-alt fa-2x\"></i></a>\r\n            </li>\r\n");
#nullable restore
#line 75 "C:\Users\User\Desktop\Memo\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"nav-item\">\r\n                <a href=\"/account/login\" class=\"nav-link\">Giriş</a>\r\n            </li>\r\n            <li class=\"nav-item\">\r\n                <a href=\"/account/register\" class=\"nav-link\">Kayıt Ol</a>\r\n            </li>\r\n");
#nullable restore
#line 84 "C:\Users\User\Desktop\Memo\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n\r\n</nav>");
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
