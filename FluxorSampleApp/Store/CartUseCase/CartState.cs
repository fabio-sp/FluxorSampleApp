using Fluxor;
using System.Collections.Immutable;
using FluxorSampleApp.Shared;

namespace FluxorSampleApp.Store.CartUseCase;

[FeatureState]
public record CartState
{
    public bool IsLoading { get; }
    public bool IsSaving { get; }

    public ImmutableArray<Item> ItemsInCart { get; } = ImmutableArray.Create<Item>();

    private CartState() { } // Serve a costruire lo stato iniziale

    public CartState(ImmutableArray<Item> itemsInCart, bool isLoading, bool isSaving)
    {
        IsSaving = isSaving;
        IsLoading = isLoading;
        ItemsInCart = itemsInCart;
    }
}
