using CheckoutKata.Core.Items.Interface;

namespace CheckoutKata.Core.Items
{
    public class BasketItemSkuC : IBasketItem
    {
        public decimal Price => BasketItemConstants.SkuCPrice;
        public string Sku => BasketItemConstants.SkuC;
    }
}