using System;
using NUnit.Framework;


namespace LookAndSay.Tests
{
    [TestFixture]
    public class LookAndSayTests
    {
        private LookAndSay lookAndSay;

        [SetUp]
        public void TestInitialize()
        {
            lookAndSay = new LookAndSay();
        }

        [TearDown]
        public void TestCleanup()
        {
            lookAndSay = null;
        }  

        [Test]
        public void LookAndSay_returns_empty_string_for_input_empty_string()
        {
            var result = lookAndSay.CalculateNextSequence(String.Empty);
            Assert.AreEqual(String.Empty, result);
        }

        [Test]
        public void LookAndSay_returns_11_for_input_1()
        {
            var result = lookAndSay.CalculateNextSequence("1");
            Assert.AreEqual("11", result);
        }

        [Test]
        public void LookAndSay_returns_311221_for_input_111211()
        {
            var result = lookAndSay.CalculateNextSequence("111211");
            Assert.AreEqual("311221", result);
        }

        [Test]
        public void LookAndSay_returns_11121314151617181910_for_input_1234567890()
        {
            var result = lookAndSay.CalculateNextSequence("1234567890");
            Assert.AreEqual("11121314151617181910", result);
        }

        [Test]
        public void LookAndSay_returns_101_for_input_1111111111()
        {
            var result = lookAndSay.CalculateNextSequence("1111111111");
            Assert.AreEqual("101", result);
        }

        [Test]
        public void LookAndSay_throws_ArgumentException_exception_if_sequence_has_non_numeric_characters()
        {
            Assert.Throws<ArgumentException>(() => lookAndSay.CalculateNextSequence("ABC"));
        }
    }
}
