using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpanishCardsDeck.Standard;

namespace SpanishCardsDeck.Test
{
    [TestClass]
    public class StandardDeckTest
    {
        [TestMethod]
        public void CorrectNumberOfCards()
        {
            var deck = new Deck();
            Assert.AreEqual(48, deck.Cards.Count);
        }

        [TestMethod]
        public void CorrectNumberOfCardsPerSign()
        {
            var deck = new Deck();
            Assert.AreEqual(12, deck.Cards.Count(c => c.Sign == Sign.Coins));
            Assert.AreEqual(12, deck.Cards.Count(c => c.Sign == Sign.Cups));
            Assert.AreEqual(12, deck.Cards.Count(c => c.Sign == Sign.Sticks));
            Assert.AreEqual(12, deck.Cards.Count(c => c.Sign == Sign.Swords));
        }
    }
}
