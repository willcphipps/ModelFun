#pragma checksum "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/ModelFun/Views/Home/Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0bcf93b7e39f0dd77e9ddb32f9b6451bdcc3549"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Users), @"mvc.1.0.view", @"/Views/Home/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Users.cshtml", typeof(AspNetCore.Views_Home_Users))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0bcf93b7e39f0dd77e9ddb32f9b6451bdcc3549", @"/Views/Home/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"779518f4f78c9c09aa2e3a4b14aee847b01b9222", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(19, 88, true);
            WriteLiteral("\n    <div class=\"jumbotron p-5 text-center\">\n        <h1>Here are some cool people</h1>\n");
            EndContext();
#line 6 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/ModelFun/Views/Home/Users.cshtml"
         foreach(var pers in Model){

#line default
#line hidden
            BeginContext(144, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(160, 14, false);
#line 7 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/ModelFun/Views/Home/Users.cshtml"
          Write(pers.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(174, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(176, 13, false);
#line 7 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/ModelFun/Views/Home/Users.cshtml"
                          Write(pers.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(189, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 8 "/Users/williamphipps/Desktop/CodingDojo/CSharp/CSharpMVC/ModelFun/Views/Home/Users.cshtml"
        }

#line default
#line hidden
            BeginContext(204, 10, true);
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591