#pragma checksum "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteCrearProyecto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b44af5117548443252a5aaebad3e5599c9ca0089"
// <auto-generated/>
#pragma warning disable 1591
namespace ServerVentas.Components.Proyectos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\_Imports.razor"
using ServerVentas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\_Imports.razor"
using ServerVentas.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\_Imports.razor"
using ServerVentas.Components.Clientes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\_Imports.razor"
using ServerVentas.Components.Proyectos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\_Imports.razor"
using ServerVentas.Components.Empleados;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\_Imports.razor"
using ServerVentas.Components.Ventas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteCrearProyecto.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteCrearProyecto.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class ComponenteCrearProyecto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteCrearProyecto.razor"
                 oProyecto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "form-group");
                __builder2.AddMarkupContent(5, "<label>Nombre Proyecto</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(6);
                __builder2.AddAttribute(7, "class", "form-control");
                __builder2.AddAttribute(8, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteCrearProyecto.razor"
                                                     oProyecto.NombreProyecto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProyecto.NombreProyecto = __value, oProyecto.NombreProyecto))));
                __builder2.AddAttribute(10, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oProyecto.NombreProyecto));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, "<label>Municipio</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteCrearProyecto.razor"
                                                     oProyecto.Municipio

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProyecto.Municipio = __value, oProyecto.Municipio))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oProyecto.Municipio));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "<label>Cliente</label>\r\n        ");
                __Blazor.ServerVentas.Components.Proyectos.ComponenteCrearProyecto.TypeInference.CreateInputSelect_0(__builder2, 24, 25, "form-control", 26, 
#nullable restore
#line 15 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteCrearProyecto.razor"
                                                       oProyecto.ClienteId

#line default
#line hidden
#nullable disable
                , 27, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProyecto.ClienteId = __value, oProyecto.ClienteId)), 28, () => oProyecto.ClienteId, 29, (__builder3) => {
#nullable restore
#line 17 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteCrearProyecto.razor"
             foreach (var cliente in clientes)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(30, "option");
                    __builder3.AddAttribute(31, "value", 
#nullable restore
#line 19 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteCrearProyecto.razor"
                                cliente.ClienteId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(32, 
#nullable restore
#line 19 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteCrearProyecto.razor"
                                                    cliente.NombreCliente

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 20 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteCrearProyecto.razor"
            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n    ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-check form-switch");
                __builder2.OpenElement(36, "input");
                __builder2.AddAttribute(37, "class", "form-check-input");
                __builder2.AddAttribute(38, "type", "checkbox");
                __builder2.AddAttribute(39, "id", "flexSwitchCheckChecked");
                __builder2.AddAttribute(40, "checked");
                __builder2.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteCrearProyecto.razor"
                                                                                                         oProyecto.Estatus

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => oProyecto.Estatus = __value, oProyecto.Estatus));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.AddMarkupContent(44, "<label class=\"form-check-label\" for=\"flexSwitchCheckChecked\">Activar Proyecto</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n    <br>\r\n    ");
                __builder2.OpenElement(46, "input");
                __builder2.AddAttribute(47, "class", "btn btn-primary");
                __builder2.AddAttribute(48, "type", "button");
                __builder2.AddAttribute(49, "value", "Guardar");
                __builder2.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteCrearProyecto.razor"
                                                                           GuardarProyecto

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteCrearProyecto.razor"
       

    EntidadProyecto oProyecto = new EntidadProyecto();
    EntidadCliente oCliente = new EntidadCliente();

    List<EntidadProyecto> proyectos = new List<EntidadProyecto>();
    List<EntidadCliente> clientes = new List<EntidadCliente>();

    protected override async Task OnInitializedAsync()
    {
        proyectos = B_Proyecto.ListaProyecto();
        clientes = B_Cliente.ListaCliente();
    }

    private void GuardarProyecto()
    {
         B_Proyecto.CrearProyecto(oProyecto);
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.ServerVentas.Components.Proyectos.ComponenteCrearProyecto
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
