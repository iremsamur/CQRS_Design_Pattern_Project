#pragma checksum "C:\Users\User\Desktop\UpSchoolBootcamp\UpSchool_CQRS_DesignPatterns\UpSchool_CQRS_DesignPatterns\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67a60af2ed7fedbf60fde435f46b22e375b0751b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\UpSchoolBootcamp\UpSchool_CQRS_DesignPatterns\UpSchool_CQRS_DesignPatterns\Views\_ViewImports.cshtml"
using UpSchool_CQRS_DesignPatterns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\UpSchoolBootcamp\UpSchool_CQRS_DesignPatterns\UpSchool_CQRS_DesignPatterns\Views\_ViewImports.cshtml"
using UpSchool_CQRS_DesignPatterns.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\UpSchoolBootcamp\UpSchool_CQRS_DesignPatterns\UpSchool_CQRS_DesignPatterns\Views\_ViewImports.cshtml"
using UpSchool_CQRS_DesignPatterns.CQRS.Results.ProductResults;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67a60af2ed7fedbf60fde435f46b22e375b0751b", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a32557455a9c9ee72cf6e621af046163cfa05b21", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetProductByAccounterQueryResult>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\UpSchoolBootcamp\UpSchool_CQRS_DesignPatterns\UpSchool_CQRS_DesignPatterns\Views\Product\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "67a60af2ed7fedbf60fde435f46b22e375b0751b4569", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""container"">
    <h2>Muhasebeci Paneli</h2>
    <br />
    <table class=""table table-bordered"">
        <tr>
            <th>#</th>
            <th>Ürün Adı</th>
            <th>Marka</th>
            <th>Stok Sayısı</th>
            <th>Detaylar İK</th>
            <th>Sil</th>
            <th>Güncelle</th>

        </tr>
");
#nullable restore
#line 21 "C:\Users\User\Desktop\UpSchoolBootcamp\UpSchool_CQRS_DesignPatterns\UpSchool_CQRS_DesignPatterns\Views\Product\Index.cshtml"
         foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\User\Desktop\UpSchoolBootcamp\UpSchool_CQRS_DesignPatterns\UpSchool_CQRS_DesignPatterns\Views\Product\Index.cshtml"
               Write(item.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\User\Desktop\UpSchoolBootcamp\UpSchool_CQRS_DesignPatterns\UpSchool_CQRS_DesignPatterns\Views\Product\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\User\Desktop\UpSchoolBootcamp\UpSchool_CQRS_DesignPatterns\UpSchool_CQRS_DesignPatterns\Views\Product\Index.cshtml"
               Write(item.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\User\Desktop\UpSchoolBootcamp\UpSchool_CQRS_DesignPatterns\UpSchool_CQRS_DesignPatterns\Views\Product\Index.cshtml"
               Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 736, "\"", 790, 2);
            WriteAttributeValue("", 743, "/Product/GetHumanResourcesIndex/", 743, 32, true);
#nullable restore
#line 27 "C:\Users\User\Desktop\UpSchoolBootcamp\UpSchool_CQRS_DesignPatterns\UpSchool_CQRS_DesignPatterns\Views\Product\Index.cshtml"
WriteAttributeValue("", 775, item.ProductID, 775, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-dark\">Detaylar</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 862, "\"", 869, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 938, "\"", 945, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n            \r\n\r\n            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\User\Desktop\UpSchoolBootcamp\UpSchool_CQRS_DesignPatterns\UpSchool_CQRS_DesignPatterns\Views\Product\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n    <br />\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 1080, "\"", 1087, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Yeni Kayıt Girişi</a>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetProductByAccounterQueryResult>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
