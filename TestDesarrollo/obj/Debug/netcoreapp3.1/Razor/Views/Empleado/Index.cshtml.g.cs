#pragma checksum "C:\Users\Luis Local\source\repos\TestDesarrollo\TestDesarrollo\Views\Empleado\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcd07d6c0d4f16c42723359399b5634b20bb8421"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_Index), @"mvc.1.0.view", @"/Views/Empleado/Index.cshtml")]
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
#line 1 "C:\Users\Luis Local\source\repos\TestDesarrollo\TestDesarrollo\Views\_ViewImports.cshtml"
using TestDesarrollo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Luis Local\source\repos\TestDesarrollo\TestDesarrollo\Views\_ViewImports.cshtml"
using TestDesarrollo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcd07d6c0d4f16c42723359399b5634b20bb8421", @"/Views/Empleado/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9be0aa717ce5022bd7e4a4409967da69832e808", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleado_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Luis Local\source\repos\TestDesarrollo\TestDesarrollo\Views\Empleado\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcd07d6c0d4f16c42723359399b5634b20bb84214677", async() => {
                WriteLiteral("\r\n    <link href=\"C:\\Users\\Luis Local\\source\\repos\\TestDesarrollo\\TestDesarrollo\\Content\\font-awesome.css\" rel=\"stylesheet\" />\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<p>
    <a>Listado Empleado</a>
</p>

<div class=""btn-group pull-right mb-2"">
    <button type='button' class=""btn btn-success"" data-toggle=""modal"" data-target=""#ModalPosicion"" id=""btnAddPosicion"" onclick=""FormaPosicion()"">Nuevo Posicion</button>

</div>
<div class=""btn-group pull-right mb-2"">
    <button type='button' class=""btn btn-info"" data-toggle=""modal"" data-target=""#ModalAgregar"" id=""btnEmpleado"" onclick=""FormaEmpleado()"">Nuevo Empleado</button>
</div>

<div class=""modal fade"" id=""ModalAgregar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">

    <div class=""modal-dialog modal-lg"">
        <div id=""modal-content"" class=""modal-content"">
            <div id=""modal-Empleado"" class=""modal-body"">
                cargando...
            </div>
        </div>
    </div>

</div>
<div class=""modal fade"" id=""ModalEditar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div id=""");
            WriteLiteral(@"modal-content"" class=""modal-content"">
            <div id=""modal-Editar"" class=""modal-body"">
                cargando...
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""ModalPosicion"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">

    <div class=""modal-dialog"">
        <div id=""modal-content"" class=""modal-content"">
            <div id=""modal-Posicion"" class=""modal-body"">
                cargando...
            </div>
        </div>
    </div>

</div>
<div class=""modal fade"" id=""ModalDelete"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">

    <div class=""modal-dialog"">
        <div id=""modal-content"" class=""modal-content"">
            <div id=""modal-Delete"" class=""modal-body"">
                cargando...
            </div>
        </div>
    </div>

</div>

<table class=""table"">
    <thead>
        <tr>
            <th>
                id
            </th>
            <th>
   ");
            WriteLiteral(@"             Nombre
            </th>
            <th>
                Apellido
            </th>

            <th>
                Fecha Nacimiento
            </th>
            <th>
                Posicion
            </th>
            <th>
                Accion
            </th>
        </tr>
    </thead>
    <tbody id=""YourBodyId"">
     
    </tbody>
</table>

<script>

    function FormaPosicion()
    {
       
        $(""#modal-Posicion"").load(""/Empleado/AdPosicion"");
    }
    function FormaEmpleado() {


        $(""#modal-Empleado"").load(""/Empleado/AddEmpleado"");
    }
    function formEditar(id)
    {
     
        $(""#modal-Editar"").load(""/Empleado/EditEmpleado/"" + id);
    }
    function formEliminar(id) {

        $(""#modal-Delete"").load(""/Empleado/DeleteEmp/"" + id);
    }

    function CreateRows(datos) {

            if (datos != null) {
                var content = document.querySelector('#YourBodyId');

                content.innerHTML = '';");
            WriteLiteral(@"
                for (let valor of datos) {
               
                    content.innerHTML += `
                    <tr>
                            <td>${valor.id}</td >
                            <td>${valor.nombre}</td >
                            <td>${valor.apellido}</td >
                            <td>${valor.fechaNacimiento}</td >
                            <td>${valor.posicion}</td >
                            <td>
                                <a href=""#ModalDelete"" class=""btnDelete  btn btn-danger btn-sm pull-right"" data-toggle=""modal"" data-id=""${valor.id}"" onclick=""formEliminar('${valor.id}')"">Eliminar</a>
                                <a href=""#ModalEditar"" class=""btnEditar  btn btn-success btn-sm fa-pull-right"" data-toggle=""modal"" data-id=""${valor.id}"" onclick=""formEditar('${valor.id}')"">Editar</a>
                            </td >

                    </tr>

                    `;
                }
            }

    }
        function GetData()
        {");
            WriteLiteral("\r\n         \r\n              $.ajax({\r\n\r\n                    url: \'");
#nullable restore
#line 149 "C:\Users\Luis Local\source\repos\TestDesarrollo\TestDesarrollo\Views\Empleado\Index.cshtml"
                     Write(Url.RouteUrl(new
                     {
                         controller = "Empleado",
                         action = "GetListEmpleado"
                     }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',

                    type: 'GET',
                    //contentType: ""application/json; charset=utf-8"",
                    dataType: ""json"",
                   success: function (data)
                   {
                    
                       CreateRows(data);


                    }

           });
    }
</script>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n      \r\n        $(document).ready(function () {\r\n            GetData();\r\n        });\r\n\r\n   \r\n    </script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcd07d6c0d4f16c42723359399b5634b20bb842111222", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcd07d6c0d4f16c42723359399b5634b20bb842112322", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcd07d6c0d4f16c42723359399b5634b20bb842113422", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 180 "C:\Users\Luis Local\source\repos\TestDesarrollo\TestDesarrollo\Views\Empleado\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 181 "C:\Users\Luis Local\source\repos\TestDesarrollo\TestDesarrollo\Views\Empleado\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591