#pragma checksum "C:\Users\emely\Tarea6\Pages\MapaPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ec49b0913c826f87f947f0a98617979ddca772e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea6.Pages
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
#line 2 "C:\Users\emely\Tarea6\Pages\MapaPage.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\emely\Tarea6\Pages\MapaPage.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\emely\Tarea6\Pages\MapaPage.razor"
using Tarea6.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/mapa")]
    public partial class MapaPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\emely\Tarea6\Pages\MapaPage.razor"
 
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    private string userId;
    protected override async Task OnInitializedAsync(){
        var authState = await authenticationStateTask;
        if(authState.User.Identity.IsAuthenticated){
            AppUser user = await UserManager.GetUserAsync(authState.User);
            userId = user.Uid.ToString();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<AppUser> UserManager { get; set; }
    }
}
#pragma warning restore 1591
