using System;


namespace PiCalculator.Tests
{
    [TestFixture]
    public class PiCalculatorTestsPart2
    {
        private PiCalculator piCalculator;

        [SetUp]
        public void TestInitialize()
        {
            piCalculator = new PiCalculator();
        }

        [TearDown]
        public void TestCleanup()
        {
            piCalculator = null;
        }

        [Test]
        public void PiCalculator_GetPiDigit_returns_1_for_input_1()
        {
            var result = piCalculator.GetPiDigit(1);
            Assert.AreEqual(1, result);
        }
    }
}
