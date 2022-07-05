using CheckoutKata.Core.Items.Interface;

namespace CheckoutKata.Core.Items
{
    public class BasketItemSkuA : IBasketItem
    {
        public decimal Price => BasketItemConstants.SkuAPrice;
        public string Sku => BasketItemConstants.SkuA;
    }
}