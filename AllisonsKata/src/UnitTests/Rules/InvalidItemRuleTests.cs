using Core;
using Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Rules
{
    [TestClass]
    public class InvalidItemRuleTests
    {
        [TestMethod]
        public void Process_NameIsSetToInvalidItemName()
        {
            var product = Product.Create("this is an invalid item", 13, 37);

            product.Rule.Process();
            
            Assert.AreEqual(Constants.InvalidItemProductName, product.Name);
        }
    }
}