#pragma checksum "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7f01a9bdf8acc4dc26898ca3b82d1d98e5cba48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OpenAQAPI_Countries), @"mvc.1.0.view", @"/Views/OpenAQAPI/Countries.cshtml")]
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
#line 1 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\_ViewImports.cshtml"
using AirQualityMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\_ViewImports.cshtml"
using AirQualityMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7f01a9bdf8acc4dc26898ca3b82d1d98e5cba48", @"/Views/OpenAQAPI/Countries.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cda19bd7a1ec99618daeab6a243b2a52bf164d91", @"/Views/_ViewImports.cshtml")]
    public class Views_OpenAQAPI_Countries : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AirQualityMVC.Models.CountryAirQuality>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"flex-column text-center align-items-center\">\r\n    <table class=\"table\" id=\"table1\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 12 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml"
               Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 15 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 18 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml"
               Write(Html.DisplayNameFor(model=>model.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 27 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml"
               Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml"
               Write(Html.DisplayFor(modelItem => item.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AirQualityMVC.Models.CountryAirQuality>> Html { get; private set; }
    }
}
#pragma warning restore 1591
