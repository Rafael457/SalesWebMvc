#pragma checksum "C:\Users\rafae\source\repos\saleswebmvc\SalesWebMvc\SalesWebMvc\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21775beace05000b47bde793a3999f73329cdb81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "C:\Users\rafae\source\repos\saleswebmvc\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "C:\Users\rafae\source\repos\saleswebmvc\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21775beace05000b47bde793a3999f73329cdb81", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dafd425af89a5439216963c7093f2ead686e4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\rafae\source\repos\saleswebmvc\SalesWebMvc\SalesWebMvc\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\rafae\source\repos\saleswebmvc\SalesWebMvc\SalesWebMvc\Views\Shared\Error.cshtml"
 if (ViewBag.ErrorTitle == null)
{

#line default
#line hidden
            BeginContext(103, 141, true);
            WriteLiteral("    <h3>\r\n        Ocorreu um erro durante o processamento da sua operação\r\n    </h3>\r\n    <h5>Contate o suporte em : suporte@email.com</h5>\r\n");
            EndContext();
#line 12 "C:\Users\rafae\source\repos\saleswebmvc\SalesWebMvc\SalesWebMvc\Views\Shared\Error.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(256, 28, true);
            WriteLiteral("    <h1 class=\"text-danger\">");
            EndContext();
            BeginContext(285, 18, false);
#line 15 "C:\Users\rafae\source\repos\saleswebmvc\SalesWebMvc\SalesWebMvc\Views\Shared\Error.cshtml"
                       Write(ViewBag.ErrorTitle);

#line default
#line hidden
            EndContext();
            BeginContext(303, 35, true);
            WriteLiteral("</h1>\r\n    <h6 class=\"text-danger\">");
            EndContext();
            BeginContext(339, 20, false);
#line 16 "C:\Users\rafae\source\repos\saleswebmvc\SalesWebMvc\SalesWebMvc\Views\Shared\Error.cshtml"
                       Write(ViewBag.ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(359, 7, true);
            WriteLiteral("</h6>\r\n");
            EndContext();
#line 17 "C:\Users\rafae\source\repos\saleswebmvc\SalesWebMvc\SalesWebMvc\Views\Shared\Error.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591