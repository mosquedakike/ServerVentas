#pragma checksum "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Clientes\ComponenteCrearCliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67d4c007b34c717948b33fbd692e917aaf9d4364"
// <auto-generated/>
#pragma warning disable 1591
namespace ServerVentas.Components.Clientes
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
#line 1 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Clientes\ComponenteCrearCliente.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Clientes\ComponenteCrearCliente.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class ComponenteCrearCliente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Clientes\ComponenteCrearCliente.razor"
                 oCliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "form-group");
                __builder2.AddMarkupContent(5, "<label>Nombre del Cliente</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(6);
                __builder2.AddAttribute(7, "class", "form-control");
                __builder2.AddAttribute(8, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Clientes\ComponenteCrearCliente.razor"
                                                      oCliente.NombreCliente

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oCliente.NombreCliente = __value, oCliente.NombreCliente))));
                __builder2.AddAttribute(10, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oCliente.NombreCliente));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-check form-switch");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "class", "form-check-input");
                __builder2.AddAttribute(16, "type", "checkbox");
                __builder2.AddAttribute(17, "id", "flexSwitchCheckChecked");
                __builder2.AddAttribute(18, "checked");
                __builder2.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Clientes\ComponenteCrearCliente.razor"
                                                                                                         oCliente.Estatus

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => oCliente.Estatus = __value, oCliente.Estatus));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.AddMarkupContent(22, "<label class=\"form-check-label\" for=\"flexSwitchCheckChecked\">Activar Cliente</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n    <br>\r\n    ");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "class", "btn btn-primary");
                __builder2.AddAttribute(26, "type", "button");
                __builder2.AddAttribute(27, "value", "Guardar");
                __builder2.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Clientes\ComponenteCrearCliente.razor"
                                                                           GuardarClinete

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
#line 18 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Clientes\ComponenteCrearCliente.razor"
       
    EntidadCliente oCliente = new EntidadCliente();

    List<EntidadCliente> clientes = new List<EntidadCliente>();

    protected override async Task OnInitializedAsync()
    {
        clientes = B_Cliente.ListaCliente();
    }

    private void GuardarClinete()
    {
        B_Cliente.CrearCliente(oCliente);
        
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
