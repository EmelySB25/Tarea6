#pragma checksum "C:\Users\emely\Tarea6\Components\AgregarTesoro.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cb362848b84748d261f9afe62920233087cd857"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea6.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\emely\Tarea6\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emely\Tarea6\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\emely\Tarea6\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\emely\Tarea6\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\emely\Tarea6\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\emely\Tarea6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\emely\Tarea6\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\emely\Tarea6\_Imports.razor"
using Tarea6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\emely\Tarea6\_Imports.razor"
using Tarea6.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\emely\Tarea6\Components\AgregarTesoro.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emely\Tarea6\Components\AgregarTesoro.razor"
using Services;

#line default
#line hidden
#nullable disable
    public partial class AgregarTesoro : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\emely\Tarea6\Components\AgregarTesoro.razor"
 
    [Parameter]
    public Guid Uid {get; set;}
    private Tesoros tesoro = new Tesoros
    {
        Id = Guid.NewGuid(),
        Date = DateTime.Today
    };
    private Coordinate coord = new Coordinate
    {
        Id = Guid.NewGuid()
    };

    private async Task HandleSubmit()
    {
        
        tesoro.Coordinates = coord;
        var status = await TS.SetTreasure(tesoro);
        if(status){
            tesoro = new Tesoros
            {
                Id = Guid.NewGuid(),
                Date = DateTime.Today
            };
            coord = new Coordinate
            {
                Id = Guid.NewGuid()
            };
            StateHasChanged();
        }
        

    }

    protected override void OnAfterRender(bool firstRender)
    {
        if(firstRender){
            if(Uid != null){
                coord.Tid = tesoro.Id;
                coord.Uid = Uid;
                tesoro.Uid = Uid;
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITesoroService TS { get; set; }
    }
}
#pragma warning restore 1591
