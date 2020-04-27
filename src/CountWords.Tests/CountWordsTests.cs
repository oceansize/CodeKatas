using System;
using NUnit.Framework;


namespace CountWords.Tests
{
    [TestFixture]
    public class CountWordsTests
    {
        private CountWords countWords;

        [SetUp]
        public void TestInitialize()
        {
            countWords = new CountWords();
        }

        [TearDown]
        public void TestCleanup()
        {
            countWords = null;
        }

        [Test]
        public void CountWords_returns_0_for_empty_string()
        {
            int result = countWords.Count(String.Empty);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CountWords_returns_2_for_HelloWorld()
        {
            int result = countWords.Count("Hello, World!");
            Assert.AreEqual(2, result);
        }

        [Test]
        public void CountWords_returns_4_for_comma_separated_list_with_no_spaces()
        {
            int result = countWords.Count("Billy,Bob,Joe,Jim");
            Assert.AreEqual(4, result);
        }
    }
}
