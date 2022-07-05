using System.Linq;
using CheckoutKata.Core.PriceStrategies.Interfaces;

namespace CheckoutKata.Core.PriceStrategies
{
    public class BasketItemSkuCItemPriceStrategy : IItemPriceStrategy
    {
        public decimal CalculatePrice(Basket basket)
        {
            var skuCBasketItems = basket.Items
                .Where(item => item.Sku == BasketItemConstants.SkuC);

            var skuCBasketItemsTotalPrice = skuCBasketItems.Sum(item => item.Price);
            return skuCBasketItemsTotalPrice;
        }
    }
}