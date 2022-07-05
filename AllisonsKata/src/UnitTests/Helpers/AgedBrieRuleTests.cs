using Core.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Helpers
{
    [TestClass]
    public class DeteriorationRateHelperTests
    {
        [TestMethod]
        public void GetSellInRelatedDeteriorationRate_ReturnsDeteriorationRate()
        {
            var rate = DeteriorationRateHelper.GetSellInRelatedDeteriorationRate(1, 1);
            
            Assert.AreEqual(1, rate);
        }
        
        [TestMethod]
        public void GetSellInRelatedDeteriorationRate_ReturnsDoubleDeteriorationRate()
        {
            var rate = DeteriorationRateHelper.GetSellInRelatedDeteriorationRate(0, 1);
            
            Assert.AreEqual(2, rate);
        }
    }
}