using CheckoutKata.Core.Items.Interface;

namespace CheckoutKata.Core.Services
{
    public interface IBasketService
    {
        public void AddItem(IBasketItem basketItem);
        public decimal GetTotal();
    }
}