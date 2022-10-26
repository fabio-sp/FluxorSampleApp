using Fluxor;

namespace FluxorSampleApp.Store.CartUseCase;

public static class Reducers
{
    [ReducerMethod]
    public static CartState ReduceAddItemToCartAction(CartState state, AddItemToCartAction action) =>
      new CartState(itemsInCart: state.ItemsInCart.Add(action.ItemToAdd));
}
