#pragma checksum "E:\Проекты\OnlineShop\OnlineShop.UI\Views\Products\Partials\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "395537064ef0872f13325371abe877f6c33cec8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Partials_ProductDetails), @"mvc.1.0.view", @"/Views/Products/Partials/ProductDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Partials/ProductDetails.cshtml", typeof(AspNetCore.Views_Products_Partials_ProductDetails))]
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
#line 1 "E:\Проекты\OnlineShop\OnlineShop.UI\Views\_ViewImports.cshtml"
using OnlineShop.UI;

#line default
#line hidden
#line 2 "E:\Проекты\OnlineShop\OnlineShop.UI\Views\_ViewImports.cshtml"
using OnlineShop.UI.Models;

#line default
#line hidden
#line 1 "E:\Проекты\OnlineShop\OnlineShop.UI\Views\Products\Partials\ProductDetails.cshtml"
using OnlineShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"395537064ef0872f13325371abe877f6c33cec8a", @"/Views/Products/Partials/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddebaa72291e7004a95201136188a9dba823d7b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Partials_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(44, 75, true);
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <td>Category:</td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(120, 92, false);
#line 9 "E:\Проекты\OnlineShop\OnlineShop.UI\Views\Products\Partials\ProductDetails.cshtml"
       Write(Html.DropDownListFor(c => c.Category, Html.GetEnumSelectList<Category>(), "Select Category"));

#line default
#line hidden
            EndContext();
            BeginContext(212, 88, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>Name:</td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(301, 28, false);
#line 15 "E:\Проекты\OnlineShop\OnlineShop.UI\Views\Products\Partials\ProductDetails.cshtml"
       Write(Html.TextBoxFor(n => n.Name));

#line default
#line hidden
            EndContext();
            BeginContext(329, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(344, 38, false);
#line 16 "E:\Проекты\OnlineShop\OnlineShop.UI\Views\Products\Partials\ProductDetails.cshtml"
       Write(Html.ValidationMessageFor(n => n.Name));

#line default
#line hidden
            EndContext();
            BeginContext(382, 89, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>Price:</td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(472, 29, false);
#line 22 "E:\Проекты\OnlineShop\OnlineShop.UI\Views\Products\Partials\ProductDetails.cshtml"
       Write(Html.TextBoxFor(p => p.Price));

#line default
#line hidden
            EndContext();
            BeginContext(501, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(516, 39, false);
#line 23 "E:\Проекты\OnlineShop\OnlineShop.UI\Views\Products\Partials\ProductDetails.cshtml"
       Write(Html.ValidationMessageFor(p => p.Price));

#line default
#line hidden
            EndContext();
            BeginContext(555, 36, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
