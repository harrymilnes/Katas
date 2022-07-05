using Core;
using Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Rules
{
    [TestClass]
    public class FrozenItemRuleTests
    {
        [TestMethod]
        public void Process_SellInDecreases()
        {
            var product = Product.Create(Constants.FrozenItemProductName, 1, 1);

            product.Rule.Process();
            
            Assert.AreEqual(0, product.SellIn);
        }
        
        [TestMethod]
        public void Process_AfterSellIn_DeterioratesOnce()
        {
            const int initialProductQuality = 10;
            var product = Product.Create(Constants.FrozenItemProductName, 2, initialProductQuality);

            product.Rule.Process();
            
            Assert.AreEqual(initialProductQuality - Constants.FrozenItemDeteriorationRate, product.Quality);
        }
        
        [TestMethod]
        public void Process_AfterSellIn_DeterioratesTwice()
        {
            const int initialProductQuality = 10;
            var product = Product.Create(Constants.FrozenItemProductName, 1, initialProductQuality);

            product.Rule.Process();
            Assert.AreEqual(initialProductQuality - (Constants.FrozenItemDeteriorationRate * 2), product.Quality);
        }
    }
}