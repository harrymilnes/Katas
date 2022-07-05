using System;
using System.Collections.Generic;
using System.Linq;
using CheckoutKata.Core.Items.Interface;
using CheckoutKata.Core.PriceStrategies.Interfaces;

namespace CheckoutKata.Core.PriceStrategies
{
    public class BasketItemSkuDItemPriceStrategy : IItemPriceStrategy
    {
        public decimal CalculatePrice(Basket basket)
        {
            var skuDBasketItems = basket.Items
                .Where(item => item.Sku == BasketItemConstants.SkuD);

            var skuDBasketItemsTotalPrice = skuDBasketItems
                .Select(it => it.Price)
                .Sum();
            
            var promotionDiscount = GetPromotionalDiscount(skuDBasketItems, skuDBasketItemsTotalPrice);
            return skuDBasketItemsTotalPrice - promotionDiscount;
        }

        private static decimal GetPromotionalDiscount(IEnumerable<IBasketItem> skuABasketItems, decimal itemsTotalPrice)
        {
            var basketItemCount = skuABasketItems.Count();
            var basketItemPairCount = Math.Floor((decimal) (basketItemCount / 2));
            
            var promotionPercentage = 25 * basketItemPairCount;
            var promotionDiscount = itemsTotalPrice / 100 * promotionPercentage;
            
            return promotionDiscount;
        }
    }
}