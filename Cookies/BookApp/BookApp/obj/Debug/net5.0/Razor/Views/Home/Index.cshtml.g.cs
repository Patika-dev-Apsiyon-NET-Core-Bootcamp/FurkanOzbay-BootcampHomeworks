#pragma checksum "C:\Users\furka\source\repos\Cookies\BookApp\BookApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d00df443173c9343ffff6e97574924a40a466020"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\furka\source\repos\Cookies\BookApp\BookApp\Views\_ViewImports.cshtml"
using BookApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\furka\source\repos\Cookies\BookApp\BookApp\Views\_ViewImports.cshtml"
using BookApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d00df443173c9343ffff6e97574924a40a466020", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34d0b2bfded0cf59895d98bcaac42a3366aec6cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BookViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\furka\source\repos\Cookies\BookApp\BookApp\Views\Home\Index.cshtml"
Write(Html.ActionLink("Favorilerimi görüntüle","Favorites","Book",null,new {@class="btn btn-secondary"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a");
            BeginWriteAttribute("href", " href=\"", 135, "\"", 167, 1);
#nullable restore
#line 5 "C:\Users\furka\source\repos\Cookies\BookApp\BookApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 142, Url.Action("Add","Book"), 142, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-danger"">Ekle</a>


<br />
<br />
<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Kitap Adı</th>
            <th scope=""col"">Yazar</th>
            <th scope=""col"">Fiyat</th>
            <th scope=""col""></th>
            <th scope=""col""></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\furka\source\repos\Cookies\BookApp\BookApp\Views\Home\Index.cshtml"
         foreach (var book in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 25 "C:\Users\furka\source\repos\Cookies\BookApp\BookApp\Views\Home\Index.cshtml"
                           Write(book.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\furka\source\repos\Cookies\BookApp\BookApp\Views\Home\Index.cshtml"
               Write(book.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\furka\source\repos\Cookies\BookApp\BookApp\Views\Home\Index.cshtml"
               Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\furka\source\repos\Cookies\BookApp\BookApp\Views\Home\Index.cshtml"
               Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n                <td><a class=\"btn btn-outline-warning\">Favorilere ekle</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 893, "\"", 951, 1);
#nullable restore
#line 30 "C:\Users\furka\source\repos\Cookies\BookApp\BookApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 900, Url.Action("Detail","Book", new { @Id = book.Id }), 900, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Detay</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\furka\source\repos\Cookies\BookApp\BookApp\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BookViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
