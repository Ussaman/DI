#pragma checksum "C:\Users\tamarix\source\repos\Ussaman\DI\WazeCredit\WazeCredit\Views\LifeTime\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d4494a6264cfd7aed6ab04252606e11cab7a100"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LifeTime_Index), @"mvc.1.0.view", @"/Views/LifeTime/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d4494a6264cfd7aed6ab04252606e11cab7a100", @"/Views/LifeTime/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e21229da0337b715e9a399cae495185b9e47312", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LifeTime_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<String>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>LifeTime Of Services</h1>\r\n");
#nullable restore
#line 4 "C:\Users\tamarix\source\repos\Ussaman\DI\WazeCredit\WazeCredit\Views\LifeTime\Index.cshtml"
  
    var count = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tamarix\source\repos\Ussaman\DI\WazeCredit\WazeCredit\Views\LifeTime\Index.cshtml"
 foreach (string mess in Model)
{
    if (count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"font-size:20px;padding-top:20px;\">\r\n            Transient Lifetime will be different for every request!\r\n        </div>\r\n");
#nullable restore
#line 14 "C:\Users\tamarix\source\repos\Ussaman\DI\WazeCredit\WazeCredit\Views\LifeTime\Index.cshtml"
    }
    if (count == 2)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"font-size:20px;padding-top:20px;\">\r\n            Scoped Lifetime will be different when you refresh!\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\tamarix\source\repos\Ussaman\DI\WazeCredit\WazeCredit\Views\LifeTime\Index.cshtml"
    }
    if (count == 4)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"font-size:20px;padding-top:20px;\">\r\n            Singleton Lifetime will be same for your application! It changes when the application restarts!\r\n        </div>\r\n");
#nullable restore
#line 26 "C:\Users\tamarix\source\repos\Ussaman\DI\WazeCredit\WazeCredit\Views\LifeTime\Index.cshtml"
    }
    count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 29 "C:\Users\tamarix\source\repos\Ussaman\DI\WazeCredit\WazeCredit\Views\LifeTime\Index.cshtml"
   Write(mess);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 31 "C:\Users\tamarix\source\repos\Ussaman\DI\WazeCredit\WazeCredit\Views\LifeTime\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<String>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
