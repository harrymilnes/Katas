using Core;
using Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Rules
{
    [TestClass]
    public class FreshItemRuleTests
    {
        [TestMethod]
        public void Process_SellIn_Decreases()
        {
            var product = Product.Create(Constants.FreshItemProductName, 1, 1);

            product.Rule.Process();
            
            Assert.AreEqual(0, product.SellIn);
        }
        
        [TestMethod]
        public void Process_AfterSellIn_DeterioratesOnce()
        {
            const int initialProductQuality = 10;
            var product = Product.Create(Constants.FreshItemProductName, 2, initialProductQuality);

            product.Rule.Process();
            
            Assert.AreEqual(initialProductQuality - Constants.FreshItemDeteriorationRate, product.Quality);
        }
        
        [TestMethod]
        public void Process_AfterSellIn_DeterioratesTwice()
        {
            const int initialProductQuality = 10;
            var product = Product.Create(Constants.FreshItemProductName, 1, initialProductQuality);

            product.Rule.Process();
            Assert.AreEqual(initialProductQuality - (Constants.FreshItemDeteriorationRate * 2), product.Quality);
        }
    }
}