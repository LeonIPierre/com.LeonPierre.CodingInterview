using System.Collections.Generic;
using System.Linq;

namespace com.LeonPierre.CodingInterview.Core
{
    public class FlushRanking : PlayerHandRankerBase
    {
        public override HandRankings Rank(IEnumerable<Card> hand, HandRankings currentRank = HandRankings.None)
        {
            if (hand.GroupBy(h => h.Suit).Count() == 1)
                return HandRankings.Flush;
            else
                return base.Rank(hand, currentRank);
        }
    }
}
