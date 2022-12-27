using System.Collections.Immutable;
using Fluxor;

namespace FluxorSampleApp.Store.CartUseCase;

public static class Reducers
{
    [ReducerMethod]
    public static CartState ReduceAddItemToCartAction(CartState cartState, AddItemToCartAction action)
        => new CartState(
            itemsInCart: cartState.ItemsInCart
            , isLoading: false
            , isSaving: true);

    [ReducerMethod]
    public static CartState ReduceAddItemToCartResultAction(CartState cartState, AddItemToCartActionResult action)
        => new CartState(
            itemsInCart: cartState.ItemsInCart.Add(action.AddedItem)
            , isLoading: false
            , isSaving: false);

    [ReducerMethod]
    public static CartState ReduceFetchItemsInCartAction(CartState cartState, FetchItemsInCartAction action)
        => new CartState(
            itemsInCart: cartState.ItemsInCart
            , isLoading: true
            , isSaving: false);

    [ReducerMethod]
    public static CartState ReduceFetchItemsInCartResultAction(CartState cartState, FetchItemsInCartResultAction action)
        => new CartState(
            itemsInCart: action.Items.ToImmutableArray()
            , isLoading: false
            , isSaving: false);
}
