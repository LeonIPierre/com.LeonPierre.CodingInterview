using System.Collections.Generic;

namespace com.LeonPierre.CodingInterview.Core
{
    public class HighCardRanking : PlayerHandRankerBase
    {
        public override HandRankings Rank(IEnumerable<Card> hand, HandRankings currentRank = HandRankings.None)
        {
            return HandRankings.HighCard;
        }
    }
}
