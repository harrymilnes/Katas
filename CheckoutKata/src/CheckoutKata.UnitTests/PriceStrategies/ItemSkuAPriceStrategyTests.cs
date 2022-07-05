using CheckoutKata.Core;
using CheckoutKata.Core.Items;
using CheckoutKata.Core.PriceStrategies;
using CheckoutKata.Core.PriceStrategies.Interfaces;
using CheckoutKata.Core.Services;
using Xunit;

namespace CheckoutKata.UnitTests.PriceStrategies
{
    public class ItemSkuAPriceStrategyTests
    {
        [Fact]
        public void ItemExists_ReturnsItemPrice()
        {
            //Arrange
            var priceStrategies = new IItemPriceStrategy[]
            {
                new BasketItemSkuAItemPriceStrategy()
            };
            
            var basket = new Basket();
            var basketService = new BasketService(basket, priceStrategies);
            
            basketService.AddItem(new BasketItemSkuA());
            
            //Act
            var totalPrice = basketService.GetTotal();
            
            //Assert
            Assert.Equal(new BasketItemSkuA().Price, totalPrice);
        }
    }
}