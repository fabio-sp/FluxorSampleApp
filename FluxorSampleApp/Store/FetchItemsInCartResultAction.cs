using FluxorSampleApp.Shared;

namespace FluxorSampleApp.Store
{
    public class FetchItemsInCartResultAction
    {
        public IEnumerable<Item> Items { get; }

        public FetchItemsInCartResultAction(IEnumerable<Item> items)
        {
            Items = items;
        }
    }
}
