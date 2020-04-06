using System;


namespace PrimeNumbers.Tests
{
    [TestFixture]
    public class PrimeNumbersTests
    {
        private PrimeNumbers primeNumbers;

        [SetUp]
        public void TestInitialize()
        {
            primeNumbers = new PrimeNumbers();
        }

        [TearDown]
        public void TestCleanup()
        {
            primeNumbers = null;
        }
        
        [Test]
        public void TestMethod1()
        {
            var result = primeNumbers.GetNextPrimeNumber(1);
            Assert.AreEqual(0, result);
        }
    }
}
