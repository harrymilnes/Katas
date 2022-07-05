using Core;
using Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Rules
{
    [TestClass]
    public class AgedBrieRuleTests
    {
        [TestMethod]
        public void Process_SellIn_Decreases()
        {
            var product = Product.Create(Constants.AgedBrieProductName, 1, 1);

            product.Rule.Process();
            
            Assert.AreEqual(0, product.SellIn);
        }
        
        [TestMethod]
        public void Process_Quality_Increases()
        {
            var product = Product.Create(Constants.AgedBrieProductName, 1, 1);

            product.Rule.Process();
            
            Assert.AreEqual(2, product.Quality);
        }
    }
}