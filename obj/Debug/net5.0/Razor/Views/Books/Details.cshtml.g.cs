#pragma checksum "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f686b15f468b25b9db09f74ee2390597edadd0ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Details), @"mvc.1.0.view", @"/Views/Books/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f686b15f468b25b9db09f74ee2390597edadd0ec", @"/Views/Books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b061b4c5514280911abcc8f1d494d06908ee8c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Books>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Details of Book</h1>\r\n");
#nullable restore
#line 8 "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\Books\Details.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Not Found Details</h2>\r\n");
#nullable restore
#line 11 "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\Books\Details.cshtml"
}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-sm-6\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 18 "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\Books\Details.cshtml"
                              Write(Model?.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 19 "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\Books\Details.cshtml"
                            Write(Model?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">");
#nullable restore
#line 20 "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\Books\Details.cshtml"
                            Write(Model?.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">");
#nullable restore
#line 21 "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\Books\Details.cshtml"
                            Write(Model?.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"card-text\">");
#nullable restore
#line 22 "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\Books\Details.cshtml"
                            Write(Model?.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <a href=\"/Books\" class=\"btn btn-primary\">Back Books</a>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 28 "C:\Users\Eltamalawy\Desktop\MVC1\MVC1\Views\Books\Details.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Books> Html { get; private set; }
    }
}
#pragma warning restore 1591
