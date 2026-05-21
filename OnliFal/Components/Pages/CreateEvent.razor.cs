using Microsoft.AspNetCore.Components;

namespace OnliFal.Components.Pages;
using Microsoft.EntityFrameworkCore ;
using OnliFal.Components.Models ;



public partial class CreateEvent : ComponentBase
{
    
    [SupplyParameterFromForm] private Event Evenement { get; set; }= new();

    protected override void OnInitialized() => Evenement ??= new();

    
    private async Task Create()
    {
        var context = DbFactory.CreateDbContext();
        context.Events.Add(Evenement);
        await context.SaveChangesAsync();
        NavigationManager.NavigateTo("/");
    }
}