using System;
using System.Runtime.InteropServices;
using NUnit.Framework;


namespace PalindromeChecker.Tests
{
    [TestFixture]
    public class PalindromeCheckerTests
    {
        private PalindromeChecker palindromeChecker;

        [SetUp]
        public void TestInitialize()
        {
            palindromeChecker = new PalindromeChecker();
        }

        [TearDown]
        public void TestCleanup()
        {
            palindromeChecker = null;
        }

        [Test]
        public void PalindromeChecker_returns_true_for_empty_string()
        {
            var result = palindromeChecker.IsPalindrome("             ");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void PalindromeChecker_returns_true_for_null()
        {
            var result = palindromeChecker.IsPalindrome(null);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void PalindromeChecker_returns_true_for_input_ABBA()
        {
            var result = palindromeChecker.IsPalindrome("ABBA");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void PalindromeChecker_returns_true_for_input_tattarrattat()
        {
            var result = palindromeChecker.IsPalindrome("tattarrattat");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void PalindromeChecker_returns_false_for_input_ABCD()
        {
            var result = palindromeChecker.IsPalindrome("ABCD");
            Assert.AreEqual(false, result);
        }

        [Test]
        public void PalindromeChecker_returns_false_for_input_palindrome()
        {
            var result = palindromeChecker.IsPalindrome("palindrome");
            Assert.AreEqual(false, result);
        }
    }
}
