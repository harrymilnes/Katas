using CheckoutKata.Core;
using CheckoutKata.Core.Items;
using CheckoutKata.Core.PriceStrategies;
using CheckoutKata.Core.PriceStrategies.Interfaces;
using CheckoutKata.Core.Services;
using Xunit;

namespace CheckoutKata.UnitTests.PriceStrategies
{
    public class ItemSkuBPriceStrategyTests
    {
        [Fact]
        public void ThreeForFortyPromotion_OneExists_ReturnsItemPrice()
        {
            //Arrange
            var priceStrategies = new IItemPriceStrategy[]
            {
                new BasketItemSkuBItemPriceStrategy()
            };
            
            var basket = new Basket();
            basket.AddItem(new BasketItemSkuB());
            
            var basketService = new BasketService(basket, priceStrategies);
            
            //Act
            var totalPrice = basketService.GetTotal();
            
            //Assert
            Assert.Equal(new BasketItemSkuB().Price, totalPrice);
        }
        
        [Fact]
        public void ThreeForFortyPromotion_ThreeExist_ReturnsPromotedPrice()
        {
            //Arrange
            var priceStrategies = new IItemPriceStrategy[]
            {
                new BasketItemSkuBItemPriceStrategy()
            };
            
            var basket = new Basket();
            basket.AddItem(new BasketItemSkuB());
            basket.AddItem(new BasketItemSkuB());
            basket.AddItem(new BasketItemSkuB());
            
            var basketService = new BasketService(basket, priceStrategies);

            //Act
            var totalPrice = basketService.GetTotal();
            
            //Assert
            Assert.Equal(40, totalPrice);
        }
    }
}