using Core;
using Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Rules
{
    [TestClass]
    public class ChristmasCrackerRuleTests
    {
        [TestMethod]
        public void Process_SellInDecreases()
        {
            var initialSellIn = 11;
            var product = Product.Create(Constants.ChristmasCrackersProductName, initialSellIn, 10);

            product.Rule.Process();
            
            Assert.AreEqual(initialSellIn - 1, product.SellIn);
        }
        
        [TestMethod]
        public void Process_QualityIncreases_WhenSellInWhenTenOrMore()
        {
            var initialQuality = 10;
            var product = Product.Create(Constants.ChristmasCrackersProductName, 12, 10);

            product.Rule.Process();
            
            Assert.AreEqual(initialQuality + 1, product.Quality);
        }
        
        [TestMethod]
        public void Process_QualityIncreasesByTwo_WhenSellInWhenTenOrLess()
        {
            var initialQuality = 10;
            var product = Product.Create(Constants.ChristmasCrackersProductName, Constants.ChristmasCrackersEarlyMatureSellIn, 10);

            product.Rule.Process();
            
            Assert.AreEqual(initialQuality + Constants.ChristmasCrackersEarlyMatureRate, product.Quality);
        }
        
        [TestMethod]
        public void Process_QualityIncreasesThree_WhenSellInWhenFiveOrLess()
        {
            var initialQuality = 10;
            var product = Product.Create(Constants.ChristmasCrackersProductName, Constants.ChristmasCrackersLateMatureSellIn, 10);

            product.Rule.Process();
            
            Assert.AreEqual(initialQuality + Constants.ChristmasCrackersLateMatureRate, product.Quality);
        }
        
        [TestMethod]
        public void Process_QualityIsZero_WhenSellInIsZero()
        {
            var product = Product.Create(Constants.ChristmasCrackersProductName, 1, 10);

            product.Rule.Process();
            
            Assert.AreEqual(0, product.Quality);
        }
    }
}