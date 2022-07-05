using CheckoutKata.Core.Items.Interface;

namespace CheckoutKata.Core.Items
{
    public class BasketItemSkuD : IBasketItem
    {
        public decimal Price => BasketItemConstants.SkuDPrice;
        public string Sku => BasketItemConstants.SkuD;
    }
}