#pragma checksum "C:\Source\DotNet\webapi\Views\Wbs\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03661c1dd3c740546b6a413f6eef8fa499e341ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wbs_Create), @"mvc.1.0.view", @"/Views/Wbs/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03661c1dd3c740546b6a413f6eef8fa499e341ee", @"/Views/Wbs/Create.cshtml")]
    public class Views_Wbs_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<webapi.Models.Wb>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Source\DotNet\webapi\Views\Wbs\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Wb</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Seq"" class=""control-label""></label>
                <input asp-for=""Seq"" class=""form-control"" />
                <span asp-validation-for=""Seq"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Id"" class=""control-label""></label>
                <input asp-for=""Id"" class=""form-control"" />
                <span asp-validation-for=""Id"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""");
            WriteLiteral(@"form-group"">
                <label asp-for=""Kana"" class=""control-label""></label>
                <input asp-for=""Kana"" class=""form-control"" />
                <span asp-validation-for=""Kana"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Ip"" class=""control-label""></label>
                <input asp-for=""Ip"" class=""form-control"" />
                <span asp-validation-for=""Ip"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Status"" class=""control-label""></label>
                <input asp-for=""Status"" class=""form-control"" />
                <span asp-validation-for=""Status"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Place"" class=""control-label""></label>
                <input asp-for=""Place"" class=""form-control"" />
                <span asp-validation-for=""Place"" class=""text-danger""></");
            WriteLiteral(@"span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Back"" class=""control-label""></label>
                <input asp-for=""Back"" class=""form-control"" />
                <span asp-validation-for=""Back"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""StartDay"" class=""control-label""></label>
                <input asp-for=""StartDay"" class=""form-control"" />
                <span asp-validation-for=""StartDay"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""StartTime"" class=""control-label""></label>
                <input asp-for=""StartTime"" class=""form-control"" />
                <span asp-validation-for=""StartTime"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""EndDay"" class=""control-label""></label>
                <input asp-for=""EndDay"" class=""form-cont");
            WriteLiteral(@"rol"" />
                <span asp-validation-for=""EndDay"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Ok"" class=""control-label""></label>
                <input asp-for=""Ok"" class=""form-control"" />
                <span asp-validation-for=""Ok"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""EndTime"" class=""control-label""></label>
                <input asp-for=""EndTime"" class=""form-control"" />
                <span asp-validation-for=""EndTime"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Phone"" class=""control-label""></label>
                <input asp-for=""Phone"" class=""form-control"" />
                <span asp-validation-for=""Phone"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Mail1"" class=""control-label""></label");
            WriteLiteral(@">
                <input asp-for=""Mail1"" class=""form-control"" />
                <span asp-validation-for=""Mail1"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Mail2"" class=""control-label""></label>
                <input asp-for=""Mail2"" class=""form-control"" />
                <span asp-validation-for=""Mail2"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Memo1"" class=""control-label""></label>
                <input asp-for=""Memo1"" class=""form-control"" />
                <span asp-validation-for=""Memo1"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Memo2"" class=""control-label""></label>
                <input asp-for=""Memo2"" class=""form-control"" />
                <span asp-validation-for=""Memo2"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
        ");
            WriteLiteral(@"        <label asp-for=""Memo3"" class=""control-label""></label>
                <input asp-for=""Memo3"" class=""form-control"" />
                <span asp-validation-for=""Memo3"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Memo4"" class=""control-label""></label>
                <input asp-for=""Memo4"" class=""form-control"" />
                <span asp-validation-for=""Memo4"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Memo5"" class=""control-label""></label>
                <input asp-for=""Memo5"" class=""form-control"" />
                <span asp-validation-for=""Memo5"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Message"" class=""control-label""></label>
                <input asp-for=""Message"" class=""form-control"" />
                <span asp-validation-for=""Message"" class=""text-danger""></span>
");
            WriteLiteral(@"            </div>
            <div class=""form-group"">
                <label asp-for=""UpdateDay"" class=""control-label""></label>
                <input asp-for=""UpdateDay"" class=""form-control"" />
                <span asp-validation-for=""UpdateDay"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""UpdateTime"" class=""control-label""></label>
                <input asp-for=""UpdateTime"" class=""form-control"" />
                <span asp-validation-for=""UpdateTime"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""FullName"" class=""control-label""></label>
                <input asp-for=""FullName"" class=""form-control"" />
                <span asp-validation-for=""FullName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Business"" class=""control-label""></label>
                <input asp-for=""Business"" c");
            WriteLiteral(@"lass=""form-control"" />
                <span asp-validation-for=""Business"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""UpdateIp"" class=""control-label""></label>
                <input asp-for=""UpdateIp"" class=""form-control"" />
                <span asp-validation-for=""UpdateIp"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""InterPhone"" class=""control-label""></label>
                <input asp-for=""InterPhone"" class=""form-control"" />
                <span asp-validation-for=""InterPhone"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 167 "C:\Source\DotNet\webapi\Views\Wbs\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<webapi.Models.Wb> Html { get; private set; }
    }
}
#pragma warning restore 1591
