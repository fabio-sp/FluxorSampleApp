using Fluxor;
using FluxorSampleApp.Data;
using System.Collections.Immutable;

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
