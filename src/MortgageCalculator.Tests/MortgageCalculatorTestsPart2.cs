using System;
using NUnit.Framework;


namespace MortgageCalculator.Tests
{
    [TestFixture]
    public class MortgageCalculatorTestsPart2
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
        public void MortgageCalculator_CalculateMonthlyPayment_1()
        {
            var result = mortgageCalculator.CalculateMonthlyPayment(1, 0, 12, 0);
            Assert.AreEqual(1, result);
        }
    }
}
