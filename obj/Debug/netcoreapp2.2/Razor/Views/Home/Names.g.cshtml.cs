#pragma checksum "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/ModelFun/Views/Home/Names.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61b3149ea780ac7ab060f146f33322bc3aad20f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Names), @"mvc.1.0.view", @"/Views/Home/Names.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Names.cshtml", typeof(AspNetCore.Views_Home_Names))]
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
#line 1 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/ModelFun/Views/_ViewImports.cshtml"
using ModelFun;

#line default
#line hidden
#line 2 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/ModelFun/Views/_ViewImports.cshtml"
using ModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61b3149ea780ac7ab060f146f33322bc3aad20f6", @"/Views/Home/Names.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"779518f4f78c9c09aa2e3a4b14aee847b01b9222", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Names : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 56, true);
            WriteLiteral("<div class=\"text-center jumbotron jumbotron-fluid m-5\">\n");
            EndContext();
            BeginContext(76, 34, true);
            WriteLiteral("    <h2>Here are some names!</h2>\n");
            EndContext();
#line 4 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/ModelFun/Views/Home/Names.cshtml"
     foreach(var name in Model){

#line default
#line hidden
            BeginContext(143, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(155, 4, false);
#line 5 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/ModelFun/Views/Home/Names.cshtml"
      Write(name);

#line default
#line hidden
            EndContext();
            BeginContext(159, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 6 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/ModelFun/Views/Home/Names.cshtml"
    }

#line default
#line hidden
            BeginContext(170, 7, true);
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
