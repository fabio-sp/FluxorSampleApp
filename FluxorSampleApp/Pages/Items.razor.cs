using System.Net.Http.Json;
using Fluxor;
using FluxorSampleApp.Shared;
using FluxorSampleApp.Store;
using FluxorSampleApp.Store.CartUseCase;
using Microsoft.AspNetCore.Components;

namespace FluxorSampleApp.Pages;

public partial class Items
{
    [Inject]
    private IState<CartState> CartState { get; set; }

    [Inject]
    public IDispatcher Dispatcher { get; set; }

    [Inject]
    public HttpClient HttpClient { get; set; }
    
    protected override async Task OnInitializedAsync()
    {
        var forecasts = await HttpClient.GetFromJsonAsync<WeatherForecast[]>("/weatherforecast");
        Console.WriteLine(forecasts);
    }

    private string Name { get; set; }
    private decimal Price { get; set; }

    private void AddItem()
    {
        var itemToAdd = new Item(Name, Price);
        var addItemAction = new AddItemToCartAction(itemToAdd);
        Dispatcher.Dispatch(addItemAction);
    }
}
