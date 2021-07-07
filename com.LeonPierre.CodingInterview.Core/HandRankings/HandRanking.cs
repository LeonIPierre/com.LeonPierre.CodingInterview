using System.Collections.Generic;

namespace com.LeonPierre.CodingInterview.Core
{
    public class HandRanking
    {
        protected IPlayerHandRanker Handler;

        public HandRanking()
        {
            var straightFlush = new StraightFlushRanking();
            var fourOfAKind = new FourOfAKindHandRanking();
            var fullHouse = new FullHouseRanking();
            var flush = new FlushRanking();
            var straight = new StraightRanking();
            var threeOfAKind = new ThreeOfAKindRanking();
            var twoPair = new TwoPairRanking();
            var pair = new PairRanking();
            var highCard = new HighCardRanking();

            straightFlush.SetNext(fourOfAKind);
            fourOfAKind.SetNext(fullHouse);
            fullHouse.SetNext(flush);
            flush.SetNext(straight);
            straight.SetNext(threeOfAKind);
            threeOfAKind.SetNext(twoPair);
            twoPair.SetNext(pair);
            pair.SetNext(highCard);
            
            Handler = straightFlush;
        }
        
        public HandRankings Rank(IEnumerable<Card> hand, HandRankings currentRank = HandRankings.None)
        {
            var result = Handler.Rank(hand, currentRank);

            return result;
        }
    }
}
