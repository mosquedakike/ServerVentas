#pragma checksum "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Evidencias\ComponenteCrearEvidencia.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acdffd17e57e03d1822f6ecd275039e9936c555e"
// <auto-generated/>
#pragma warning disable 1591
namespace ServerVentas.Components.Evidencias
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
#line 15 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\_Imports.razor"
using ServerVentas.Components.Evidencias;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Evidencias\ComponenteCrearEvidencia.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Evidencias\ComponenteCrearEvidencia.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class ComponenteCrearEvidencia : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Evidencias\ComponenteCrearEvidencia.razor"
                 oEmpleado

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "form-group");
                __builder2.AddMarkupContent(5, "<label>Nombre del Empleado</label>\r\n        ");
                __builder2.OpenComponent<ServerVentas.Shared.InputImg>(6);
                __builder2.AddAttribute(7, "Label", "Foto");
                __builder2.AddAttribute(8, "ImagenSeleccionada", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 23 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Evidencias\ComponenteCrearEvidencia.razor"
                                                   ImagenSeleccionada

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(9, "ImagenURL", "ImagenURL");
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Evidencias\ComponenteCrearEvidencia.razor"
       
    EntidadEvidencia oEvidencia = new EntidadEvidencia();
    EntidadEmpleado oEmpleado = new EntidadEmpleado();
    List<EntidadEmpleado> empleados = new List<EntidadEmpleado>();

    [Parameter]
    public EntidadEvidencia Evidencia { get; set; }

    [Parameter]
    public EventCallback OnValidSubmit { get; set; }

    string imagenURL;

    //protected override void OnInitialized()
    //{
    //    if (!string.IsNullOrEmpty(Evidencia.Foto))
    //    {
    //        imagenURL = Evidencia.Foto;
    //        Evidencia.Foto = null;
    //    }
    //}

    //protected override async Task OnInitializedAsync()
    //{
    //    empleados = B_Empleado.ListaEmpleado();

    //}

    private void ImagenSeleccionada(string imagenBase64)
    {
        Evidencia.Foto = imagenBase64;
        imagenURL = null;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591