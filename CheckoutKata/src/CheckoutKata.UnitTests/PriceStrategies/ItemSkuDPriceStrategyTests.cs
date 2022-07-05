using CheckoutKata.Core;
using CheckoutKata.Core.Items;
using CheckoutKata.Core.PriceStrategies;
using CheckoutKata.Core.PriceStrategies.Interfaces;
using CheckoutKata.Core.Services;
using Xunit;

namespace CheckoutKata.UnitTests.PriceStrategies
{
    public class ItemSkuDPriceStrategyTests
    {
        [Fact]
        public void PercentageOffPromotion_MultipleD_ReturnsTotalDiscountedPrice()
        {
            //Arrange
            var priceStrategies = new IItemPriceStrategy[]
            {
                new BasketItemSkuDItemPriceStrategy()
            };
            
            var basket = new Basket();
            basket.AddItem(new BasketItemSkuD());
            basket.AddItem(new BasketItemSkuD());
            
            var basketService = new BasketService(basket, priceStrategies);
            
            //Act
            var totalPrice = basketService.GetTotal();
            
            //Assert
            Assert.Equal((decimal) 82.50, totalPrice);
        }
        
        [Fact]
        public void PercentageOffPromotion_OneExists_ReturnsItemPrice()
        {
            //Arrange
            var priceStrategies = new IItemPriceStrategy[]
            {
                new BasketItemSkuDItemPriceStrategy()
            };
            
            var basket = new Basket();
            basket.AddItem(new BasketItemSkuD());

            var basketService = new BasketService(basket, priceStrategies);
            
            //Act
            var totalPrice = basketService.GetTotal();
            
            //Assert
            Assert.Equal(new BasketItemSkuD().Price, totalPrice);
        }
        
        [Fact]
        public void PercentageOffPromotion_QuadD_ReturnsTotalDiscountedPrice()
        {
            //Arrange
            var priceStrategies = new IItemPriceStrategy[]
            {
                new BasketItemSkuDItemPriceStrategy()
            };
            
            var basket = new Basket();
            basket.AddItem(new BasketItemSkuD());
            basket.AddItem(new BasketItemSkuD());
            basket.AddItem(new BasketItemSkuD());
            basket.AddItem(new BasketItemSkuD());
            
            var basketService = new BasketService(basket, priceStrategies);
            
            //Act
            var totalPrice = basketService.GetTotal();
            
            //Assert
            Assert.Equal(110, totalPrice);
        }
    }
}