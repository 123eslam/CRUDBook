#pragma checksum "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\Books\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "091d6c185af10c891a8f544a8c0e1728e24ad4e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Index), @"mvc.1.0.view", @"/Views/Books/Index.cshtml")]
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
#line 1 "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\_ViewImports.cshtml"
using MVC1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\_ViewImports.cshtml"
using MVC1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"091d6c185af10c891a8f544a8c0e1728e24ad4e4", @"/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b061b4c5514280911abcc8f1d494d06908ee8c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Page of Books</h1>\r\n<a href=\"/Books/AddBook\" class=\"btn btn-primary\">Add Book</a>\r\n");
#nullable restore
#line 9 "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\Books\Index.cshtml"
 foreach (Books d in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-6\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">Id: ");
#nullable restore
#line 14 "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\Books\Index.cshtml"
                                      Write(d.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4 class=\"card-text\">Name: ");
#nullable restore
#line 15 "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\Books\Index.cshtml"
                                       Write(d.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4 class=\"card-text\">Price: ");
#nullable restore
#line 16 "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\Books\Index.cshtml"
                                        Write(d.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4 class=\"card-text\">CategoryId: ");
#nullable restore
#line 17 "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\Books\Index.cshtml"
                                             Write(d.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4 class=\"card-text\">AuthorId: ");
#nullable restore
#line 18 "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\Books\Index.cshtml"
                                           Write(d.AuthorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 671, "\"", 698, 2);
            WriteAttributeValue("", 678, "/Books/Details/", 678, 15, true);
#nullable restore
#line 19 "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\Books\Index.cshtml"
WriteAttributeValue("", 693, d.Id, 693, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" target=\"_blank\">Details</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 771, "\"", 802, 2);
            WriteAttributeValue("", 778, "/Books/UppdateBook/", 778, 19, true);
#nullable restore
#line 20 "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\Books\Index.cshtml"
WriteAttributeValue("", 797, d.Id, 797, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" target=\"_blank\">Uppdate data</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 880, "\"", 906, 2);
            WriteAttributeValue("", 887, "/Books/Delete/", 887, 14, true);
#nullable restore
#line 21 "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\Books\Index.cshtml"
WriteAttributeValue("", 901, d.Id, 901, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" target=\"_blank\">Delet</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 25 "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\Books\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .card{\r\n        margin:20px\r\n    }\r\n</style>\r\n");
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