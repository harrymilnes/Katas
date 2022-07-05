using Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Rules
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void Create_HasCorrectName()
        {
            var initialProductName = "TestProduct";
            
            var product = Product.Create(initialProductName, 1, 1);
            
            Assert.AreEqual(initialProductName, product.Name);
        }
        
        [TestMethod]
        public void Create_HasCorrectSellIn()
        {
            var initialSellIn = 30;
            
            var product = Product.Create("Test Product", initialSellIn, 1);
            
            Assert.AreEqual(initialSellIn, product.SellIn);
        }
        
        [TestMethod]
        public void Create_HasCorrectQuality()
        {
            var initalQuality = 30;
            
            var product = Product.Create("Test Product", 1, initalQuality);
            
            Assert.AreEqual(initalQuality, product.Quality);
        }

        [TestMethod]
        public void Output_InvalidItem_ReturnsNoSuchItem()
        {
            var product = Product.Create("Invalid Item", 1, -1);
            product.Rule.Process();
            var output = product.Output();
            
            Assert.AreEqual("NO SUCH ITEM", output);
        }
        
        [TestMethod]
        public void Output_QualityCannotExceedFifty_ReturnsQualityOfFifty()
        {
            var product = Product.Create("Soap", 0, 55);
            product.Rule.Process();
            var output = product.Output();
            
            Assert.AreEqual("Soap 0 50", output);
        }
        
        [TestMethod]
        public void Output_QualityCannotBeLessThanZero_ReturnsQualityOfZero()
        {
            var product = Product.Create("Soap", 0, -1);
            product.Rule.Process();
            var output = product.Output();
            
            Assert.AreEqual("Soap 0 0", output);
        }
    }
}