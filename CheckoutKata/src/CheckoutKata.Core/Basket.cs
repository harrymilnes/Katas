using System.Collections.Generic;
using System.Collections.ObjectModel;
using CheckoutKata.Core.Items.Interface;

namespace CheckoutKata.Core
{
    public class Basket
    {
        public IList<IBasketItem> Items { get; } = new Collection<IBasketItem>();

        public void AddItem(IBasketItem basketItem)
        {
            Items.Add(basketItem);
        }
    }
}