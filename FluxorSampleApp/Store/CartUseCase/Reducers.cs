using Fluxor;

namespace FluxorSampleApp.Store.CartUseCase
{
    public static class Reducers
    {
        [ReducerMethod]
        public static CartState ReduceIncrementCounterAction(CartState state, AddItemToStoreAction action) =>
          new CartState(itemsInCart: state.ItemsInCart.Add(action.ItemToAdd));
    }
}
