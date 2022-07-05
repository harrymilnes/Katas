namespace CheckoutKata.Core.PriceStrategies.Interfaces
{
    public interface IItemPriceStrategy
    {
        public decimal CalculatePrice(Basket basket);
    }
}