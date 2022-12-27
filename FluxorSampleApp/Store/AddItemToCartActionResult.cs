using FluxorSampleApp.Shared;

namespace FluxorSampleApp.Store;

public class AddItemToCartActionResult
{
    public Item AddedItem { get; }

    public AddItemToCartActionResult(Item itemToAdd)
    {
        this.AddedItem = itemToAdd;
    }
}