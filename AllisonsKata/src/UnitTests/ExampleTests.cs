using Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ExampleTests
    {
        [TestMethod]
        public void AgedBrie_SellInOne_QuantityOne()
        {
            var product = Product.Create("Aged Brie", 1, 1);

            product.Rule.Process();
            var output = product.Output();
            
            Assert.AreEqual("Aged Brie 0 2", output);
        }
        
        [TestMethod]
        public void ChristmasCrackers_SellInMinusOne_QualityTwo()
        {
            var product = Product.Create("Christmas Crackers", -1, 2);

            product.Rule.Process();
            var output = product.Output();
            
            Assert.AreEqual("Christmas Crackers -2 0", output);
        }        
        
        [TestMethod]
        public void ChristmasCrackers_SellInNine_QualityTwo()
        {
            var product = Product.Create("Christmas Crackers", 9, 2);

            product.Rule.Process();
            var output = product.Output();
            
            Assert.AreEqual("Christmas Crackers 8 4", output);
        }
        
        [TestMethod]
        public void Soap_SellInTwo_QualityTwo()
        {
            var product = Product.Create("Soap", 2, 2);

            product.Rule.Process();
            var output = product.Output();
            
            Assert.AreEqual("Soap 2 2", output);
        }
        
        [TestMethod]
        public void FrozenItem_SellInMinusOne_QualityFiftyFive()
        {
            var product = Product.Create("Frozen Item", -1, 55);

            product.Rule.Process();
            var output = product.Output();
            
            Assert.AreEqual("Frozen Item -2 50", output);
        }
        
        [TestMethod]
        public void FrozenItem_SellInTwo_QualityTwo()
        {
            var product = Product.Create("Frozen Item", 2, 2);

            product.Rule.Process();
            var output = product.Output();
            
            Assert.AreEqual("Frozen Item 1 1", output);
        }
        
        [TestMethod]
        public void InvalidItem_SellInTwo_QualityTwo()
        {
            var product = Product.Create("Invalid Item", 2, 2);

            product.Rule.Process();
            var output = product.Output();
            
            Assert.AreEqual("NO SUCH ITEM", output);
        }
        
        [TestMethod]
        public void FreshItem_SellInTwo_QualityTwo()
        {
            var product = Product.Create("Fresh Item", 2, 2);

            product.Rule.Process();
            var output = product.Output();
            
            Assert.AreEqual("Fresh Item 1 0", output);
        }
        
        [TestMethod]
        public void FreshItem_SellInMinusOne_QualityFive()
        {
            var product = Product.Create("Fresh Item", -1, 5);

            product.Rule.Process();
            var output = product.Output();
            
            Assert.AreEqual("Fresh Item -2 1", output);
        }
    }
}