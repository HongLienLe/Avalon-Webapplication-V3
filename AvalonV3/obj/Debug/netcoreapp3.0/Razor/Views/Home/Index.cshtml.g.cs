#pragma checksum "/Users/hongle/Projects/AvalonV3/AvalonV3/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dbcd5644c3c652203233934d8d210c659322716"
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
#line 1 "/Users/hongle/Projects/AvalonV3/AvalonV3/Views/_ViewImports.cshtml"
using AvalonV3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hongle/Projects/AvalonV3/AvalonV3/Views/_ViewImports.cshtml"
using AvalonV3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dbcd5644c3c652203233934d8d210c659322716", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f6a6a488f7760174b6d692337cad82e0a074c42", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AvalonV3.Models.Character>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/hongle/Projects/AvalonV3/AvalonV3/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1> Choose your player</h1>\n</div>\n\n<div class=\"container\">\n  <div class=\"row\">\n\n");
#nullable restore
#line 14 "/Users/hongle/Projects/AvalonV3/AvalonV3/Views/Home/Index.cshtml"
 foreach (var character in Model)
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("   <div class=\"col-sm\">\n        <div class=\"card mb-3\">\n            <h3 class=\"card-header\">");
#nullable restore
#line 18 "/Users/hongle/Projects/AvalonV3/AvalonV3/Views/Home/Index.cshtml"
                               Write(character.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n            <div class=\"text-center\">\n                <img style=\"width: 100px;\" class=\"text-center\"");
            BeginWriteAttribute("src", " src=\"", 452, "\"", 491, 1);
#nullable restore
#line 20 "/Users/hongle/Projects/AvalonV3/AvalonV3/Views/Home/Index.cshtml"
WriteAttributeValue("", 458, Url.Content(character.ImagePath), 458, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image\">\n                <div class=\"card-body\">\n                    <p class=\"card-text\"> ");
#nullable restore
#line 22 "/Users/hongle/Projects/AvalonV3/AvalonV3/Views/Home/Index.cshtml"
                                     Write(character.Team);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p>");
#nullable restore
#line 23 "/Users/hongle/Projects/AvalonV3/AvalonV3/Views/Home/Index.cshtml"
                  Write(character.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p>In play = ");
#nullable restore
#line 24 "/Users/hongle/Projects/AvalonV3/AvalonV3/Views/Home/Index.cshtml"
                            Write(character.ChoosenPlayer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <div class=\"text-center\">\n                         <a");
            BeginWriteAttribute("href", " href=\"", 798, "\"", 863, 1);
#nullable restore
#line 26 "/Users/hongle/Projects/AvalonV3/AvalonV3/Views/Home/Index.cshtml"
WriteAttributeValue("", 805, Url.Action("SelectCharacters", new { id = character.Id }), 805, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-warning btn-sm margin-right"">
                        <span class=""glyphicon glyphicon-edit""></span><span class=""hidden-xs""> Select</span>
                    </a>
                    </div>
                </div>
             </div>
        </div>
   </div>
");
#nullable restore
#line 34 "/Users/hongle/Projects/AvalonV3/AvalonV3/Views/Home/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\n</div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AvalonV3.Models.Character>> Html { get; private set; }
    }
}
#pragma warning restore 1591
