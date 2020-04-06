

using NUnit.Framework;

namespace PigLatin.Tests
{
    [TestFixture]
    public class PigLatinTestsPart1
    {
        private PigLatin pigLatin;

        [SetUp]
        public void TestInitialize()
        {
            pigLatin = new PigLatin();
        }

        [TearDown]
        public void TestCleanup()
        {
            pigLatin = null;
        }

        [Test]
        public void PigLatin_returns_ellohay_for_input_hello()
        {
            string result = pigLatin.EnglishToPigLatin("hello");
            Assert.AreEqual("ellohay", result);
        }

        [Test]
        public void PigLatin_returns_iway_for_input_i()
        {
            string result = pigLatin.EnglishToPigLatin("i");
            Assert.AreEqual("iway", result);
        }

        [Test]
        public void PigLatin_returns_oveglay_for_input_glove()
        {
            string result = pigLatin.EnglishToPigLatin("glove");
            Assert.AreEqual("oveglay", result);
        }

        /* Uncomment here for Extra Credit
        
       [Test]
       public void PigLatin_returns_EthayIckquayOwnbrayOxfayOverwayEthayAzylayOgday_for_input_TheQuickBrownFoxJumpsOverTheLazyDog()
       {
           var result = pigLatin.EnglishToPigLatin("The quick, brown fox jumps over the lazy dog.");
           Assert.AreEqual("Ethay ickquay, ownbray oxfay umpsjay overway ethay azylay ogday.", result);
       }
        
       [Test]
       public void PigLatin_returns_OdecayAtaskaArewayAwayOodgayAywayOtayOnehayOuryayIllsskay_for_input_ CodeKatasAreAGoodWayToHoneYourSkills()
       {
           var result = pigLatin.EnglishToPigLatin("Code Katas are a good way to hone your skills.");
           Assert.AreEqual("Odecay Ataskay areway away oodgay ayway otay onehay ouryay illsskay.",result);
       }
       */
    }
}
