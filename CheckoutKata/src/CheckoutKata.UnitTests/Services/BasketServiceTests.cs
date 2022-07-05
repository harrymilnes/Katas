using CheckoutKata.Core;
using CheckoutKata.Core.Items;
using CheckoutKata.Core.PriceStrategies;
using CheckoutKata.Core.PriceStrategies.Interfaces;
using CheckoutKata.Core.Services;
using Xunit;

namespace CheckoutKata.UnitTests.Services
{
    public class BasketServiceTests
    {
        [Fact]
        public void ItemAdded()
        {
            //Arrange
            var basket = new Basket();
            var basketItem = new BasketItemSkuA();
            
            //Act
            basket.AddItem(basketItem);

            //Assert
            Assert.NotEmpty(basket.Items);
        }

        [Fact]
        public void GetPrice_ItemAdded_ReturnsPrice()
        {
            //Arrange
            var priceStrategies = new IItemPriceStrategy[]
            {
                new BasketItemSkuAItemPriceStrategy()
            };
            
            var basket = new Basket();
            basket.AddItem(new BasketItemSkuA());
            
            var basketService = new BasketService(basket, priceStrategies);

            //Act
            var basketPrice = basketService.GetTotal();

            //Assert
            Assert.Equal(new BasketItemSkuA().Price, basketPrice);
        }
    }
}