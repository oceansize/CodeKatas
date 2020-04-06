using System;
using NUnit.Framework;


namespace MortgageCalculator.Tests
{
    [TestFixture]
    public class MortgageCalculatorTestsPart3
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
        public void MortgageCalculator_CalculateDownPayment_1()
        {
            var result = mortgageCalculator.CalculateDownPayment(1, 0, 12, 1);
            Assert.AreEqual(0, result);
        }
    }
}
