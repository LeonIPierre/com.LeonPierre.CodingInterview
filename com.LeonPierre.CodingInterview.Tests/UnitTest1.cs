using System;
using System.Collections.Generic;
using com.LeonPierre.CodingInterview.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.LeonPierre.CodingInterview.Tests
{
    [TestClass]
    public class UnitTest1
    {
        protected Deck Deck;

        [TestInitialize]
        public void Setup()
        {
            Deck = new Deck();
        }

        [TestMethod]
        public void WhenInitialized_DeckShouldHave52Cards()
        {
            //arrange
            //act

            //assert
            Assert.IsTrue(Deck.Cards.Count == 52);
        }

        [TestMethod]
        public void WhenDrawn_DeckShouldHave47Cards()
        {
            //arrange
            //act
            var drawnCards = Deck.Draw(5);

            //assert
            Assert.IsTrue(Deck.Cards.Count == 47);
        }

        [TestMethod]
        public void WhenDrawn_DeckShouldDrawFirst5HeartsCards()
        {
            //arrange
            var player = new Player("", null);
            IEnumerable<Card> cardsToBeDrawn = new List<Card>()
            {
                { new Card(Suit.Heart, CardValue.Ace) },
                { new Card(Suit.Heart, CardValue.Two) },
                { new Card(Suit.Heart, CardValue.Three) },
                { new Card(Suit.Heart, CardValue.Four) },
                { new Card(Suit.Heart, CardValue.Five) }
            };

            //act
            var drawnCards = Deck.Draw(5);

            //assert
            Assert.IsTrue(drawnCards == cardsToBeDrawn);
        }
    }
}
