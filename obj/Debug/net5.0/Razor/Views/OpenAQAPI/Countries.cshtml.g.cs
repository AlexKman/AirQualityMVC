#pragma checksum "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7c1870aebf1d5ffc09480afa9c091f2c68360c8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7c1870aebf1d5ffc09480afa9c091f2c68360c8", @"/Views/OpenAQAPI/Countries.cshtml")]
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
            WriteLiteral("\r\n<div class=\"container\">\r\n    <table class=\"table table-bordered\" id=\"dataTable\" width=\"100%\" cellspacing=\"0\">\r\n        <thead>\r\n            <tr class=\"table-headers\">\r\n                <th>\r\n                    ");
#nullable restore
#line 12 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 15 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml"
               Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 19 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml"
               Write(Html.DisplayNameFor(model => model.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 22 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml"
               Write(Html.DisplayNameFor(model => model.Cities));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n\r\n                </th>\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml"
               Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml"
               Write(Html.DisplayFor(modelItem => item.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cities));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml"
               Write(Html.ActionLink("View Cities", "Cities", new { Code = item.Code }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 51 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\Countries.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<style>\r\n    .table {\r\n        background-color: white;\r\n        padding: 20em;\r\n    }\r\n\r\n    .container {\r\n    }\r\n\r\n    .table-headers > th {\r\n        cursor: pointer;\r\n    }\r\n</style>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral(@"    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.18/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.18/js/dataTables.bootstrap4.min.js""></script>
    <script>
        $(document).ready(function () {
            $('#dataTable').DataTable();
        });
    </script>
");
            }
            );
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
