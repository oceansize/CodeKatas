using System;


namespace PiCalculator.Tests
{
    [TestFixture]
    public class PiCalculatorTestsPart1
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
        public void PiCalculator_GetPi_returns_314_for_input_2()
        {
            var result = piCalculator.GetPi(2);
            Assert.AreEqual("3.14", result);
        }
    }
}
