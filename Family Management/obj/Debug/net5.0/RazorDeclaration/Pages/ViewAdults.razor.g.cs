// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Family_Management.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/satish/RiderProjects/DNP/Family Management/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/satish/RiderProjects/DNP/Family Management/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/satish/RiderProjects/DNP/Family Management/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/satish/RiderProjects/DNP/Family Management/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/satish/RiderProjects/DNP/Family Management/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/satish/RiderProjects/DNP/Family Management/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/satish/RiderProjects/DNP/Family Management/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/satish/RiderProjects/DNP/Family Management/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/satish/RiderProjects/DNP/Family Management/_Imports.razor"
using Family_Management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/satish/RiderProjects/DNP/Family Management/_Imports.razor"
using Family_Management.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/satish/RiderProjects/DNP/Family Management/Pages/ViewAdults.razor"
using Family_Management.Data.AdultsData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/satish/RiderProjects/DNP/Family Management/Pages/ViewAdults.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/satish/RiderProjects/DNP/Family Management/Pages/ViewAdults.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewAdults")]
    public partial class ViewAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "/Users/satish/RiderProjects/DNP/Family Management/Pages/ViewAdults.razor"
       
    private IList<Adult> allAdults;
    private IList<Adult> AdultsToShow;

   

    private void FilterByUserId(ChangeEventArgs changeEventArgs)
    {
        int? filterbyId = null;
        try
        {
            filterbyId = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
        }
        if (filterbyId != null)
        {
            AdultsToShow = allAdults.Where(t => t.Id == filterbyId).ToList();
        }
        else
        {
            AdultsToShow = allAdults;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        allAdults = IAdults.GetAdults();
        AdultsToShow = allAdults;
    }
   
     private void RemoveAdult(int AdultId)
    {
        Adult adultToRemove = allAdults.First(t => t.Id == AdultId);
        // IAdults.RemoveAdult(AdultId);
        allAdults.Remove(adultToRemove);
        AdultsToShow.Remove(adultToRemove);
    }

    private void Edit(int id)
    {
        NavigationManager.NavigateTo($"Edit/{id}");
    }
    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdults IAdults { get; set; }
    }
}
#pragma warning restore 1591
