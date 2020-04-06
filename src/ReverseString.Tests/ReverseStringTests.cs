using System;


namespace ReverseString.Tests
{
    [TestFixture]
    public class ReverseStringTests
    {
        private ReverseString reverseString;

        [SetUp]
        public void TestInitialize()
        {
            reverseString = new ReverseString();
        }

        [TearDown]
        public void TestCleanup()
        {
            reverseString = null;
        }
        
        [Test]
        public void ReverseString_HelloWorld()
        {
            string result = reverseString.Reverse("Hello, World!");
            Assert.AreEqual("!dlroW ,olleH", result);
        }

        [Test]
        public void ReverseString_called_twice_returns_original_value()
        {
            const string expected = "Hello, World!";
            string result = reverseString.Reverse(reverseString.Reverse(expected));
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ReverseString_returns_empty_string_for_input_of_empty_string()
        {
            string result = reverseString.Reverse(String.Empty);
            Assert.AreEqual(String.Empty, result);
        }
    }
}
