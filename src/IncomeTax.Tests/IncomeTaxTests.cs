using NUnit.Framework;

namespace IncomeTax.Tests
{
    [TestFixture]
    public class IncomeTaxTests
    {
        private IncomeTax _incomeTax;

        [SetUp]
        public void TestInitialize()
        {
            _incomeTax = new IncomeTax();
        }

        [TearDown]
        public void TestCleanup()
        {
            _incomeTax = null;
        }

        [Test]
        public void No_Income_Returns_0()
        {
            int result = _incomeTax.CalculateTax(0);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Negative_Income_Returns_0()
        {
            int result = _incomeTax.CalculateTax(-1);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void Income_Of_10000_Returns_1085()
        {
            int result = _incomeTax.CalculateTax(10000);
            Assert.AreEqual(1085, result);
        }

        [Test]
        public void Income_Of_20000_Returns_2554()
        {
            int result = _incomeTax.CalculateTax(20000);
            Assert.AreEqual(2554, result);
        }

        [Test]
        public void Income_Of_450000_Returns_135964()
        {
            int result = _incomeTax.CalculateTax(450000);
            Assert.AreEqual(135964, result);
        }
    }
}
