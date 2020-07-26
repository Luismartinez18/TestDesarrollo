#pragma checksum "C:\Users\Luis Local\source\repos\TestDesarrollo\TestDesarrollo\Views\Empleado\EditEmp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "967340be8661b51943b46afd15c623cf4dca6a56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_EditEmp), @"mvc.1.0.view", @"/Views/Empleado/EditEmp.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"967340be8661b51943b46afd15c623cf4dca6a56", @"/Views/Empleado/EditEmp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9be0aa717ce5022bd7e4a4409967da69832e808", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleado_EditEmp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\Luis Local\source\repos\TestDesarrollo\TestDesarrollo\Views\Empleado\EditEmp.cshtml"
  
    ViewData["Title"] = "AddEmpleado";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"PanelMod text-center mt-5 \">\r\n    <h4><a class=\" fa fa-money\"></a> Agregar Nuevo Empleado</h4>\r\n</div>\r\n<div class=\"row \">\r\n    <div class=\"col-lg-12 mx-auto\">\r\n        <div class=\"form-group\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "967340be8661b51943b46afd15c623cf4dca6a563937", async() => {
                WriteLiteral(@"
                <div class=""form-row"">
                    <div class=""form-group col-md-6"">
                        <input type=""number"" class=""form-control"" id=""txtid"" hidden=""hidden"" />
                        <label class=""font-weight-bold"">Nombre</label>
                        <input type=""text"" id=""txtNombre"" class=""form-control"" placeholder=""Nombre Empleado"" required=""required"" />

                        <div class=""invalid-feedback"">Este campo no puede estar vacio</div>
                    </div>
                    <div class=""form-group col-md-6"">
                        <label class=""font-weight-bold"">Apellido</label>
                        <input type=""text"" id=""txtApellido"" class=""form-control"" placeholder=""Apellido Empleado"" required=""required"" />
                        <div class=""invalid-feedback"">Este campo no puede estar vacio</div>
                    </div>
                </div>

                <div class=""form-row"">
                    <div class=""form-group col-md");
                WriteLiteral(@"-6"">
                        <label class=""font-weight-bold"">Cedula</label>
                        <input type=""text"" id=""txtCedular"" class=""form-control"" placeholder=""Cedula .."" required=""required"" />
                        <div class=""invalid-feedback"">El campo cedula no puede estar Vacio</div>
                    </div>
                    <div class=""form-group col-md-6"">
                        <label>Fecha Nacimiento</label>
                        <input type=""date"" id=""txtFecha"" class=""form-control"" />
                    </div>
                </div>
                <div class=""form-row"">
                    <div class=""form-group col-md-6"">
                        <label>Telefono</label>
                        <input type=""text"" id=""txtTelefono"" class=""form-control"" placeholder=""Telefono .."" />
                    </div>
                    <div class=""form-group col-md-6"">
                        <label class=""font-weight-bold"">Posicion</label>
                        <select id");
                WriteLiteral("=\"cbPosicion\" class=\"form-control\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "967340be8661b51943b46afd15c623cf4dca6a566466", async() => {
                    WriteLiteral("Selecion Posicion");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </select>
                    </div>
                </div>

                <div class=""form-group"">
                    <label>Direccion</label>
                    <input type=""text"" id=""txtDireccion"" class=""form-control"" placeholder=""Direccion"" />
                </div>



                <div class=""modal-footer"">

                    <button type=""submit"" id=""btnAgregar"" class=""btn btn-success mb-2"" onclick=""AgregarEmpleado()"">Agregar</button>
                    <button type=""button"" class=""btn btn-danger mb-2"" data-dismiss=""modal"">Cancelar</button>

                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<script>\r\n    $(document).ready(function ()\r\n    {\r\n        ListOption();\r\n    });\r\n    function ListOption()\r\n    {\r\n         $.ajax({\r\n                    url: \'");
#nullable restore
#line 82 "C:\Users\Luis Local\source\repos\TestDesarrollo\TestDesarrollo\Views\Empleado\EditEmp.cshtml"
                     Write(Url.RouteUrl(new
                     {
                         controller = "Empleado",
                         action = "GetListPosicion"
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

                        GetListPosicion(data);

                    }

           });
    }
    function GetListPosicion(data)
    {
        for (var i = 0; i < data.length; i++) {
            var select = document.getElementById(""cbPosicion"");
            var option = document.createElement(""option"");
            option.text = data[i].descrpcion;
            option.value = data[i].id;
            select.add(option);
        }

    }

            function AgregarEmpleado()
            {

                var modelo = {
                    id: 0,
                    Nombre: document.getElementById(""txtNombre"").value,
                    Apellido: document.getElementById(""txtApellido"").value,
                    Cedula: document.getElementById(""txtCedular"").value,
     ");
            WriteLiteral(@"               FechaNacimiento: document.getElementById(""txtFecha"").value,
                    IdPosicion: document.getElementById(""cbPosicion"").value,
                    Telefono: document.getElementById(""txtTelefono"").value,
                    Direccion: document.getElementById(""txtDireccion"").value,

                }

                        $.ajax({

                            data: modelo,
                            url: '");
#nullable restore
#line 130 "C:\Users\Luis Local\source\repos\TestDesarrollo\TestDesarrollo\Views\Empleado\EditEmp.cshtml"
                             Write(Url.RouteUrl(new
                             {
                                 controller = "Empleado",
                                 action = "EditEmpleado"
                             }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',

                            type: 'POST',
                            //contentType: ""application/json; charset=utf-8"",
                            dataType: ""json"",
                            success: function (data) {
                                debugger
                                window.location.href = ""../Empleado/index"";

                            },
                            error: function (data) {

                                window.location.href = ""../Empleado/index"";
                            }
                        });
            }
</script>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 153 "C:\Users\Luis Local\source\repos\TestDesarrollo\TestDesarrollo\Views\Empleado\EditEmp.cshtml"
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
