using System;


namespace CaesarCipher.Tests
{
    [TestFixture]
    public class CaesarCipherTestsPart2
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
        public void CaesarCipher_decodes_hello_world_with_4_shift()
        {
            var result = caesarCipher.Encode("Lipps, Asvph!", 4);
            Assert.AreEqual("Hello, World!", result);
        }

        [Test]
        public void CaesarCipher_dncode_does_not_alter_numbers()
        {
            var result = caesarCipher.Encode("BCD123", 1);
            Assert.AreEqual("ABC123", result);
        }
    }
}
