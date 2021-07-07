using com.LeonPierre.CodingInterview.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Collections.Generic;

namespace com.LeonPierre.CodingInterview.Tests
{
    [TestFixture]
    public class HandRankingsUnitTest
    {
        protected HandRanking HandRanking;


        [SetUp]
        public void Setup()
        {
            HandRanking = new HandRanking();
        }

        //[Test]
        [Test, TestCaseSource("GetUserLists")]
        public void TestMethod1(Card[] hand)
        {
            IEnumerable<Card> cardsToBeDrawn = new List<Card>()
            {
                //{ new Card(Suit.Heart, CardValue.Ace) },
                { new Card(Suit.Heart, CardValue.Two) },
                { new Card(Suit.Heart, CardValue.Three) },
                { new Card(Suit.Heart, CardValue.Four) },
                { new Card(Suit.Heart, CardValue.Five) },
                { new Card(Suit.Spade, CardValue.Six) }
            };

            var result = HandRanking.Rank(cardsToBeDrawn);
            
        }
    }
}
