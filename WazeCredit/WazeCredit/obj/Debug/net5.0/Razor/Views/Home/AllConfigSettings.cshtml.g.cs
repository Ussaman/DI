#pragma checksum "C:\Users\tamarix\source\repos\Ussaman\DI\WazeCredit\WazeCredit\Views\Home\AllConfigSettings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83f399917aa1d23a560c7bf71130849efa844768"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllConfigSettings), @"mvc.1.0.view", @"/Views/Home/AllConfigSettings.cshtml")]
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
#line 1 "C:\Users\tamarix\source\repos\Ussaman\DI\WazeCredit\WazeCredit\Views\_ViewImports.cshtml"
using WazeCredit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tamarix\source\repos\Ussaman\DI\WazeCredit\WazeCredit\Views\_ViewImports.cshtml"
using WazeCredit.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f399917aa1d23a560c7bf71130849efa844768", @"/Views/Home/AllConfigSettings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e21229da0337b715e9a399cae495185b9e47312", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_AllConfigSettings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"p-4\">\r\n    <h3>Following are the configurations from AppSettings:</h3>\r\n    <ul>\r\n");
#nullable restore
#line 6 "C:\Users\tamarix\source\repos\Ussaman\DI\WazeCredit\WazeCredit\Views\Home\AllConfigSettings.cshtml"
         foreach(var message in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 8 "C:\Users\tamarix\source\repos\Ussaman\DI\WazeCredit\WazeCredit\Views\Home\AllConfigSettings.cshtml"
           Write(message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 9 "C:\Users\tamarix\source\repos\Ussaman\DI\WazeCredit\WazeCredit\Views\Home\AllConfigSettings.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
