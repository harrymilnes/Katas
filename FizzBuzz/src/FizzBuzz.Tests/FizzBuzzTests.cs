using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {
        [TestMethod()]
        public void NumberNotDivisibleByThreeOrFive()
        {
            int input = 1;

            var output = FizzBuzz.CheckInput(input);

            Assert.AreEqual("1", output);
        }

        [TestMethod()]
        public void FizzWhenNumberDivisibleByThree()
        {
            int input = 3;

            var output = FizzBuzz.CheckInput(input);

            Assert.AreEqual("Fizz", output);
        }

        [TestMethod()]
        public void BuzzWhenNumberDivisibleByFive()
        {
            int input = 5;

            var output = FizzBuzz.CheckInput(input);

            Assert.AreEqual("Buzz", output);
        }

        [TestMethod()]
        public void FizzBuzzWhenNumberDivisibleByThreeAndFive()
        {
            int input = 15;

            var output = FizzBuzz.CheckInput(input);

            Assert.AreEqual("FizzBuzz", output);
        }
    }
}