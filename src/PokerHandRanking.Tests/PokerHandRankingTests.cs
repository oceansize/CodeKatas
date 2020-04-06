using System;
using System.Collections.Generic;
using NUnit.Framework;


namespace PokerHandRanking.Tests
{
    [TestFixture]
    public class PokerHandRankingTests
    {
        private PokerHandRanking pokerHandRanking;

        [SetUp]
        public void TestInitialize()
        {
            pokerHandRanking = new PokerHandRanking();
        }

        [TearDown]
        public void TestCleanup()
        {
            pokerHandRanking = null;
        }
        
        [Test]
        public void PokerHandRanking_returns_royal_flush()
        {
            var hand = new List<Card>()
            {
                new Card() { Rank = Rank.Ace, Suit = Suit.Club },
                new Card() { Rank = Rank.King, Suit = Suit.Club },
                new Card() { Rank = Rank.Queen, Suit = Suit.Club },
                new Card() { Rank = Rank.Jack, Suit = Suit.Club },
                new Card() { Rank = Rank.Ten, Suit = Suit.Club }
            };

            var result = pokerHandRanking.RankHand(hand);

            Assert.AreEqual("Royal Flush", result);
        }
    }
}
