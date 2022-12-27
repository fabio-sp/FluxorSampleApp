using System.Net.Http.Json;
using Fluxor;
using FluxorSampleApp.Shared;

namespace FluxorSampleApp.Store.CartUseCase
{
    public class Effects
    {
        private readonly HttpClient _httpClient;

        public Effects(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [EffectMethod]
        public async Task HandleFetchItemsInCartAction(FetchItemsInCartAction action, IDispatcher dispatcher)
        {
            var itemsInCart = await _httpClient.GetFromJsonAsync<Item[]>("/cart-items");
            dispatcher.Dispatch(new FetchItemsInCartResultAction(itemsInCart));
        }

        [EffectMethod]
        public async Task HandleAddItemToCartAction(AddItemToCartAction action, IDispatcher dispatcher)
        {
            await _httpClient.PostAsJsonAsync("/cart-items", action.ItemToAdd);
            dispatcher.Dispatch(new AddItemToCartActionResult(action.ItemToAdd));
        }
    }
}
