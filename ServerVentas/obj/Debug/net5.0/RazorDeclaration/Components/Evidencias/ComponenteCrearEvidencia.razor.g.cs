// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
