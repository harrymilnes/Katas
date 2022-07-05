using CheckoutKata.Core;
using CheckoutKata.Core.Items;
using CheckoutKata.Core.PriceStrategies;
using CheckoutKata.Core.PriceStrategies.Interfaces;
using CheckoutKata.Core.Services;
using Xunit;

namespace CheckoutKata.UnitTests.PriceStrategies
{
    public class ItemSkuCPriceStrategyTests
    {
        [Fact]
        public void ItemExists_ReturnsItemPrice()
        {
            //Arrange
            var priceStrategies = new IItemPriceStrategy[]
            {
                new BasketItemSkuCItemPriceStrategy()
            };
            
            var basket = new Basket();
            basket.AddItem(new BasketItemSkuC());

            var basketService = new BasketService(basket, priceStrategies);
            
            //Act
            var totalPrice = basketService.GetTotal();
            
            //Assert
            Assert.Equal(new BasketItemSkuC().Price, totalPrice);
        }
    }
}