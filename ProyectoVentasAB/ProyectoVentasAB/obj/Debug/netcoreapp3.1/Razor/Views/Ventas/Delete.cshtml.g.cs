#pragma checksum "C:\Users\Alondra\Desktop\Prueba2Trabajo\ProyectoVentas\ProyectoVentasAB\ProyectoVentasAB\Views\Ventas\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f45896f5b049cf6c285e256289841a52c001b253"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ventas_Delete), @"mvc.1.0.view", @"/Views/Ventas/Delete.cshtml")]
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
#line 1 "C:\Users\Alondra\Desktop\Prueba2Trabajo\ProyectoVentas\ProyectoVentasAB\ProyectoVentasAB\Views\_ViewImports.cshtml"
using ProyectoVentasAB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alondra\Desktop\Prueba2Trabajo\ProyectoVentas\ProyectoVentasAB\ProyectoVentasAB\Views\_ViewImports.cshtml"
using ProyectoVentasAB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f45896f5b049cf6c285e256289841a52c001b253", @"/Views/Ventas/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c030ea2c4cc6c2dd5b9285417720c84d3cc03de", @"/Views/_ViewImports.cshtml")]
    public class Views_Ventas_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProyectoVentasAB.Models.tblVentas>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-footer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alondra\Desktop\Prueba2Trabajo\ProyectoVentas\ProyectoVentasAB\ProyectoVentasAB\Views\Ventas\Delete.cshtml"
  
    ViewData["Title"] = "Venta";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<
<div class=""col-6 offset-3"">
    <div class=""card"">
        <div class=""card-header bg-danger"">
            <h5 class=""card-title text-center"">Eliminar Venta</h5>
        </div>
        <div class=""card-body"">
            <dl>
                <dt class=""col-sm-5"">
                    ");
#nullable restore
#line 16 "C:\Users\Alondra\Desktop\Prueba2Trabajo\ProyectoVentas\ProyectoVentasAB\ProyectoVentasAB\Views\Ventas\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.FechaVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-md-5 col-sm-6\">\r\n                    ");
#nullable restore
#line 19 "C:\Users\Alondra\Desktop\Prueba2Trabajo\ProyectoVentas\ProyectoVentasAB\ProyectoVentasAB\Views\Ventas\Delete.cshtml"
               Write(Html.DisplayFor(model => model.FechaVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-5\">\r\n                    ");
#nullable restore
#line 22 "C:\Users\Alondra\Desktop\Prueba2Trabajo\ProyectoVentas\ProyectoVentasAB\ProyectoVentasAB\Views\Ventas\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-md-5 col-sm-6\">\r\n                    ");
#nullable restore
#line 25 "C:\Users\Alondra\Desktop\Prueba2Trabajo\ProyectoVentas\ProyectoVentasAB\ProyectoVentasAB\Views\Ventas\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-5\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\Alondra\Desktop\Prueba2Trabajo\ProyectoVentas\ProyectoVentasAB\ProyectoVentasAB\Views\Ventas\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-md-5 col-sm-6\">\r\n                    ");
#nullable restore
#line 31 "C:\Users\Alondra\Desktop\Prueba2Trabajo\ProyectoVentas\ProyectoVentasAB\ProyectoVentasAB\Views\Ventas\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-5\">\r\n                    ");
#nullable restore
#line 34 "C:\Users\Alondra\Desktop\Prueba2Trabajo\ProyectoVentas\ProyectoVentasAB\ProyectoVentasAB\Views\Ventas\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.SubTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-md-5 col-sm-6\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\Alondra\Desktop\Prueba2Trabajo\ProyectoVentas\ProyectoVentasAB\ProyectoVentasAB\Views\Ventas\Delete.cshtml"
               Write(Html.DisplayFor(model => model.SubTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-5\">\r\n                    ");
#nullable restore
#line 40 "C:\Users\Alondra\Desktop\Prueba2Trabajo\ProyectoVentas\ProyectoVentasAB\ProyectoVentasAB\Views\Ventas\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-md-5 col-sm-6\">\r\n                    ");
#nullable restore
#line 43 "C:\Users\Alondra\Desktop\Prueba2Trabajo\ProyectoVentas\ProyectoVentasAB\ProyectoVentasAB\Views\Ventas\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-5\">\r\n                    ");
#nullable restore
#line 46 "C:\Users\Alondra\Desktop\Prueba2Trabajo\ProyectoVentas\ProyectoVentasAB\ProyectoVentasAB\Views\Ventas\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.IdProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-md-5 col-sm-6\">\r\n                    ");
#nullable restore
#line 49 "C:\Users\Alondra\Desktop\Prueba2Trabajo\ProyectoVentas\ProyectoVentasAB\ProyectoVentasAB\Views\Ventas\Delete.cshtml"
               Write(Html.DisplayFor(model => model.IdProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-5\">\r\n                    ");
#nullable restore
#line 52 "C:\Users\Alondra\Desktop\Prueba2Trabajo\ProyectoVentas\ProyectoVentasAB\ProyectoVentasAB\Views\Ventas\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.IdTienda));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-md-5 col-sm-6\">\r\n                    ");
#nullable restore
#line 55 "C:\Users\Alondra\Desktop\Prueba2Trabajo\ProyectoVentas\ProyectoVentasAB\ProyectoVentasAB\Views\Ventas\Delete.cshtml"
               Write(Html.DisplayFor(model => model.IdTienda));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f45896f5b049cf6c285e256289841a52c001b25311272", async() => {
                WriteLiteral("\r\n            <h6>Seguro de eliminar este registro?</h6>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f45896f5b049cf6c285e256289841a52c001b25311601", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 61 "C:\Users\Alondra\Desktop\Prueba2Trabajo\ProyectoVentas\ProyectoVentasAB\ProyectoVentasAB\Views\Ventas\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdVenta);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-danger\" /> |\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f45896f5b049cf6c285e256289841a52c001b25313439", async() => {
                    WriteLiteral("Regresar!");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoVentasAB.Models.tblVentas> Html { get; private set; }
    }
}
#pragma warning restore 1591
