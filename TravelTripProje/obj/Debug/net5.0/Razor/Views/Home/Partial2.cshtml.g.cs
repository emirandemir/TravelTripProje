#pragma checksum "C:\Users\DEMİR\Source\Repos\TravelTripProje\TravelTripProje\Views\Home\Partial2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "036a6da20a52559c80ad86c605a54f094fc97e80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Partial2), @"mvc.1.0.view", @"/Views/Home/Partial2.cshtml")]
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
#line 1 "C:\Users\DEMİR\Source\Repos\TravelTripProje\TravelTripProje\Views\_ViewImports.cshtml"
using TravelTripProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DEMİR\Source\Repos\TravelTripProje\TravelTripProje\Views\_ViewImports.cshtml"
using TravelTripProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\DEMİR\Source\Repos\TravelTripProje\TravelTripProje\Views\Home\Partial2.cshtml"
using TravelTripProje.Models.Siniflar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"036a6da20a52559c80ad86c605a54f094fc97e80", @"/Views/Home/Partial2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d084c3ae0a7137e2b8d07d7013d35a151e772e04", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Partial2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\DEMİR\Source\Repos\TravelTripProje\TravelTripProje\Views\Home\Partial2.cshtml"
     foreach (var x in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"right\">\r\n\r\n        <div class=\"bot-left\">\r\n            <img src=\"images/pic2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 192, "\"", 198, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"left-text\">\r\n\r\n            <h4>");
#nullable restore
#line 13 "C:\Users\DEMİR\Source\Repos\TravelTripProje\TravelTripProje\Views\Home\Partial2.cshtml"
           Write(x.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <span class=\"doller\">");
#nullable restore
#line 14 "C:\Users\DEMİR\Source\Repos\TravelTripProje\TravelTripProje\Views\Home\Partial2.cshtml"
                            Write(x.Tarih.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <p>");
#nullable restore
#line 15 "C:\Users\DEMİR\Source\Repos\TravelTripProje\TravelTripProje\Views\Home\Partial2.cshtml"
          Write(x.Aciklama.Substring(0, 5));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><a");
            BeginWriteAttribute("href", " href=\"", 425, "\"", 453, 2);
            WriteAttributeValue("", 432, "/Blog/BlogDetay/", 432, 16, true);
#nullable restore
#line 16 "C:\Users\DEMİR\Source\Repos\TravelTripProje\TravelTripProje\Views\Home\Partial2.cshtml"
WriteAttributeValue("", 448, x.ID, 448, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"read\">Daha Fazlası...>></span></a></p>\r\n        </div>\r\n        \r\n    </div>\r\n");
#nullable restore
#line 20 "C:\Users\DEMİR\Source\Repos\TravelTripProje\TravelTripProje\Views\Home\Partial2.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
