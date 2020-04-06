using System;
using System.Runtime.InteropServices;


namespace CaesarCipher.Tests
{
    [TestFixture]
    public class CaesarCipherTestsPart1
    {
        private CaesarCipher caesarCipher;

        [SetUp]
        public void TestInitialize()
        {
            caesarCipher = new CaesarCipher();
        }

        [TearDown]
        public void TestCleanup()
        {
            caesarCipher = null;
        }  

        [Test]
        public void CaesarCipher_encodes_hello_world_with_4_shift()
        {
            var result = caesarCipher.Encode("Hello, World!", 4);
            Assert.AreEqual("Lipps, Asvph!", result);
        }

        [Test]
        public void CaesarCipher_encode_does_not_alter_numbers()
        {
            var result = caesarCipher.Encode("ABC123", 1);
            Assert.AreEqual("BCD123", result);
        }
    }
}
