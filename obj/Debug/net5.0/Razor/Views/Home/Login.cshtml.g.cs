#pragma checksum "/Users/latuconsinafr/Personal/IT/Practices/ASP.NET/apps/basic-auth/Views/Home/Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51393a0cb2d8a7fc940a03d21c5e6f95cc93bf7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.razor-page", @"/Views/Home/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51393a0cb2d8a7fc940a03d21c5e6f95cc93bf7b", @"/Views/Home/Login.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Login Page</h1>\n\n<form action=\"/Home/Login\" method=\"post\">\n    <input type=\"text\" name=\"username\"");
            BeginWriteAttribute("value", " value=\"", 113, "\"", 121, 0);
            EndWriteAttribute();
            WriteLiteral("/>\n    <input type=\"text\" name=\"password\"");
            BeginWriteAttribute("value", " value=\"", 163, "\"", 171, 0);
            EndWriteAttribute();
            WriteLiteral("/>\n    <button type=\"submit\">Login</button>\n</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Views_Home_Login> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Home_Login> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Home_Login>)PageContext?.ViewData;
        public Views_Home_Login Model => ViewData.Model;
    }
}
#pragma warning restore 1591