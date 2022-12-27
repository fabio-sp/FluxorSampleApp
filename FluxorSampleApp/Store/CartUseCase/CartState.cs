using Fluxor;
using System.Collections.Immutable;
using FluxorSampleApp.Shared;

namespace FluxorSampleApp.Store.CartUseCase;

[FeatureState]
public record CartState
{
    public ImmutableArray<Item> ItemsInCart { get; } = ImmutableArray.Create<Item>();

    private CartState() { } // Serve a costruire lo stato iniziale

    public CartState(ImmutableArray<Item> itemsInCart)
    {
        ItemsInCart = itemsInCart;
    }
}
