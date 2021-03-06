#pragma checksum "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteListaProyecto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c332893dc3b72ac66dffa647367e8084f8cdbc3"
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
#line 15 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\_Imports.razor"
using ServerVentas.Components.Evidencias;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteListaProyecto.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteListaProyecto.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class ComponenteListaProyecto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-hover table-bordered");
            __builder.AddMarkupContent(2, "<thead><tr><th>ID</th>\r\n            <th>Nombre del Proyecto</th>\r\n            <th>Municipio</th>\r\n            <th></th></tr></thead>\r\n    ");
            __builder.OpenElement(3, "tbody");
#nullable restore
#line 14 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteListaProyecto.razor"
         foreach (var proyecto in proyectos)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "tr");
            __builder.OpenElement(5, "td");
            __builder.AddContent(6, 
#nullable restore
#line 17 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteListaProyecto.razor"
                     proyecto.ProyectoId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n                ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 18 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteListaProyecto.razor"
                     proyecto.NombreProyecto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 19 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteListaProyecto.razor"
                     proyecto.Municipio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "href", "proyecto/actualizar/" + (
#nullable restore
#line 20 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteListaProyecto.razor"
                                                  proyecto.ProyectoId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Actualizar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteListaProyecto.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\enriq\source\repos\ServerVentas\ServerVentas\Components\Proyectos\ComponenteListaProyecto.razor"
       
    List<EntidadProyecto> proyectos = new List<EntidadProyecto>();

    protected override async Task OnInitializedAsync()
    {
        proyectos = B_Proyecto.ListaProyecto();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
