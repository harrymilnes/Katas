using CheckoutKata.Core.Items.Interface;

namespace CheckoutKata.Core.Items
{
    public class BasketItemSkuB : IBasketItem
    {
        public decimal Price => BasketItemConstants.SkuBPrice;
        public string Sku => BasketItemConstants.SkuB;
    }
}