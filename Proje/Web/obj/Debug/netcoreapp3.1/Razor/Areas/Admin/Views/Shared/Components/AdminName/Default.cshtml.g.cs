#pragma checksum "C:\Users\İbrahim Bayram\Documents\GitHub\Haber-Sitesi-Projesi\Proje\Web\Areas\Admin\Views\Shared\Components\AdminName\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76a51fd5c2fd0d4b1f7acb11ae7bc16e4b18bccc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_AdminName_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/AdminName/Default.cshtml")]
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
#line 1 "C:\Users\İbrahim Bayram\Documents\GitHub\Haber-Sitesi-Projesi\Proje\Web\Areas\Admin\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\İbrahim Bayram\Documents\GitHub\Haber-Sitesi-Projesi\Proje\Web\Areas\Admin\Views\_ViewImports.cshtml"
using Dto.DTOS.NewsDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76a51fd5c2fd0d4b1f7acb11ae7bc16e4b18bccc", @"/Areas/Admin/Views/Shared/Components/AdminName/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa54ab726aae7567f27c0929cda55e5ce5b58517", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_AdminName_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<li><a class=\"dropdown-button waves-effect waves-dark\" href=\"#!\" data-activates=\"dropdown1\"><i class=\"fa fa-user fa-fw\"></i> <b>");
#nullable restore
#line 1 "C:\Users\İbrahim Bayram\Documents\GitHub\Haber-Sitesi-Projesi\Proje\Web\Areas\Admin\Views\Shared\Components\AdminName\Default.cshtml"
                                                                                                                           Write(ViewBag.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> <i class=\"material-icons right\">arrow_drop_down</i></a></li>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
