using System.Collections.Generic;

namespace com.LeonPierre.CodingInterview.Core
{
    public class HighCardRanking : PlayerHandRankerBase
    {
        public override HandRankings Rank(IEnumerable<Card> hand, HandRankings currentRank = HandRankings.None)
        {
            //if (hand.Or)
                return HandRankings.HighCard;
            //else
            //    return NextHandler.Rank(hand, currentRank);
        }
    }
}
