#pragma checksum "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\_CityMeasurementsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ff8d852008b2f27b575e3df610a33621aaf8720"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OpenAQAPI__CityMeasurementsPartial), @"mvc.1.0.view", @"/Views/OpenAQAPI/_CityMeasurementsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ff8d852008b2f27b575e3df610a33621aaf8720", @"/Views/OpenAQAPI/_CityMeasurementsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cda19bd7a1ec99618daeab6a243b2a52bf164d91", @"/Views/_ViewImports.cshtml")]
    public class Views_OpenAQAPI__CityMeasurementsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AirQualityMVC.Models.CityMeasurements>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">
    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
        <thead>
            <tr class=""table-headers"">
                <th>
                    Chemical Name:
                </th>
                <th>
                    Chemical Value:
                </th>
                </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 17 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\_CityMeasurementsPartial.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 21 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\_CityMeasurementsPartial.cshtml"
   Write(Html.DisplayFor(modelItem => item.Parameter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n");
#nullable restore
#line 24 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\_CityMeasurementsPartial.cshtml"
           var result = item.Value + " " + item.Unit; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\_CityMeasurementsPartial.cshtml"
                                                 Write(Html.DisplayFor(modelItem => result));

#line default
#line hidden
#nullable disable
            WriteLiteral("    </td>\n</tr>\n");
#nullable restore
#line 27 "C:\Users\Alex K\source\repos\AirQualityMVC\Views\OpenAQAPI\_CityMeasurementsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>\n\n\n<style>\n    .table {\n        background-color: white;\n        padding: 20em;\n    }\n\n    .container {\n    }\n\n    .table-headers > th {\n        cursor: pointer;\n    }\n</style>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AirQualityMVC.Models.CityMeasurements>> Html { get; private set; }
    }
}
#pragma warning restore 1591
