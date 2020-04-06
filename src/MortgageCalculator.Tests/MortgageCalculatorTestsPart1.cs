using System;


namespace MortgageCalculator.Tests
{
    [TestFixture]
    public class MortgageCalculatorTestsPart1
    {
        private MortgageCalculator mortgageCalculator;

        [SetUp]
        public void TestInitialize()
        {
            mortgageCalculator = new MortgageCalculator();
        }

        [TearDown]
        public void TestCleanup()
        {
            mortgageCalculator = null;
        }
        
        [Test]
        public void MortgageCalculator_CalculatePurchasePrice_1()
        {
            var result = mortgageCalculator.CalculatePurchasePrice(1, 1, 1, 1);
            Assert.AreEqual(12.95, result);
        }
    }
}
