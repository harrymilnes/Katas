using System.Collections.Generic;
using CheckoutKata.Core.Items.Interface;
using CheckoutKata.Core.PriceStrategies.Interfaces;

namespace CheckoutKata.Core.Services
{
    public class BasketService : IBasketService
    {
        private readonly Basket _basket;
        private readonly IEnumerable<IItemPriceStrategy> _itemPriceStrategies;

        public BasketService(
            Basket basket, 
            IEnumerable<IItemPriceStrategy> itemPriceStrategies)
        {
            _basket = basket;
            _itemPriceStrategies = itemPriceStrategies;
        }

        public void AddItem(IBasketItem basketItem)
        {
            _basket.AddItem(basketItem);
        }

        public decimal GetTotal() => CalculateTotalBasketCost();

        private decimal CalculateTotalBasketCost()
        {
            decimal calculatedPrice = 0;
            foreach (var priceStrategy in _itemPriceStrategies)
            {
                calculatedPrice = priceStrategy.CalculatePrice(_basket);
            }

            return calculatedPrice;
        }
    }
}