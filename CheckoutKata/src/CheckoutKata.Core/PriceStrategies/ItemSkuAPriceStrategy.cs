using System.Linq;
using CheckoutKata.Core.PriceStrategies.Interfaces;

namespace CheckoutKata.Core.PriceStrategies
{
    public class BasketItemSkuAItemPriceStrategy : IItemPriceStrategy
    {
        public decimal CalculatePrice(Basket basket)
        {
            var skuABasketItems = basket.Items
                .Where(item => item.Sku == BasketItemConstants.SkuA);

            var skuBBasketItemsTotalPrice = skuABasketItems.Sum(item => item.Price);
            return skuBBasketItemsTotalPrice;
        }
    }
}