using FluxorSampleApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxorSampleApp.Store
{
    public class AddItemToStoreAction
    {
        public Item ItemToAdd { get; }

        public AddItemToStoreAction(Item itemToAdd)
        {
            this.ItemToAdd = itemToAdd;
        }
    }
}
