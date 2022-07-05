using Core;
using Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Rules
{
    [TestClass]
    public class SoapRuleTests
    {
        [TestMethod]
        public void Process_SellIn_StaysTheSame()
        {
            const int initialSellIn = 1;
            var product = Product.Create(Constants.SoapProductName, 1, 1);

            product.Rule.Process();
            
            Assert.AreEqual(initialSellIn, product.SellIn);
        }
        
        [TestMethod]
        public void Process_Quality_Increases()
        {
            const int initialQuality = 1;
            var product = Product.Create(Constants.SoapProductName, 1, 1);

            product.Rule.Process();
            
            Assert.AreEqual(initialQuality, product.Quality);
        }
    }
}