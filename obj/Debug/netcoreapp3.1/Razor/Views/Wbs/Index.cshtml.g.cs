#pragma checksum "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72deb96ff97596ab5672a91928798c5468e30817"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wbs_Index), @"mvc.1.0.view", @"/Views/Wbs/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72deb96ff97596ab5672a91928798c5468e30817", @"/Views/Wbs/Index.cshtml")]
    public class Views_Wbs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<webapi.Models.Wb>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Kana));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Back));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StartDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EndDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ok));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EndTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mail1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mail2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 61 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Memo1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 64 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Memo2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 67 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Memo3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 70 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Memo4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 73 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Memo5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 76 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 79 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdateDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 82 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 85 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 88 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Business));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 91 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdateIp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 94 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InterPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 100 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 106 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 109 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Kana));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 112 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 115 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 118 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 121 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Back));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 124 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 127 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 130 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EndDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 133 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ok));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 136 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EndTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 139 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 142 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mail1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 145 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mail2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 148 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Memo1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 151 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Memo2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 154 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Memo3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 157 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Memo4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 160 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Memo5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 163 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 166 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UpdateDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 169 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UpdateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 172 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 175 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Business));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 178 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UpdateIp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 181 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.InterPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 5629, "\"", 5653, 1);
#nullable restore
#line 184 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
WriteAttributeValue("", 5644, item.Seq, 5644, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 5706, "\"", 5730, 1);
#nullable restore
#line 185 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
WriteAttributeValue("", 5721, item.Seq, 5721, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 5785, "\"", 5809, 1);
#nullable restore
#line 186 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
WriteAttributeValue("", 5800, item.Seq, 5800, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 189 "C:\Source\DotNet\webapi\Views\Wbs\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<webapi.Models.Wb>> Html { get; private set; }
    }
}
#pragma warning restore 1591
