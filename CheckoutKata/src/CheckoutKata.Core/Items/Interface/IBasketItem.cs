namespace CheckoutKata.Core.Items.Interface
{
    public interface IBasketItem
    {
        public decimal Price { get; }
        public string Sku { get; }
    }
}