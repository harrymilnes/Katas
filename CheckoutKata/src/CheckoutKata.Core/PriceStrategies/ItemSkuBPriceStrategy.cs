using System;
using System.Collections.Generic;
using System.Linq;
using CheckoutKata.Core.Items.Interface;
using CheckoutKata.Core.PriceStrategies.Interfaces;

namespace CheckoutKata.Core.PriceStrategies
{
    public class BasketItemSkuBItemPriceStrategy : IItemPriceStrategy
    {
        public decimal CalculatePrice(Basket basket)
        {
            var skuBBasketItems = basket.Items
                .Where(item => item.Sku == BasketItemConstants.SkuB);

            var skuBBasketItemsTotalPrice = skuBBasketItems
                .Select(it => it.Price)
                .Sum();
            
            var promotionDiscount = GetPromotionalDiscount(skuBBasketItems);
            return skuBBasketItemsTotalPrice - promotionDiscount;
        }

        private static decimal GetPromotionalDiscount(IEnumerable<IBasketItem> skuABasketItems)
        {
            var basketItemCount = skuABasketItems.Count();
            var basketItemTripleGroupingCount = Math.Floor((decimal) (basketItemCount / 3));
            
            var promotionDiscount = 5 * basketItemTripleGroupingCount;
            return promotionDiscount;
        }
    }
}
