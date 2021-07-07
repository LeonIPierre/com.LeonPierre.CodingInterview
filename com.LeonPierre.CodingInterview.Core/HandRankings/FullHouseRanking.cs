using System.Collections.Generic;
using System.Linq;

namespace com.LeonPierre.CodingInterview.Core
{
    public class FullHouseRanking : PlayerHandRankerBase
    {
        public override HandRankings Rank(IEnumerable<Card> hand, HandRankings currentRank = HandRankings.None)
        {
            if (hand.GroupBy(h => h.Value)
                       .Where(g => g.Count() == 2)
                       .Count() == 1 && hand.GroupBy(h => h.Value)
                       .Where(g => g.Count() == 3)
                       .Count() == 1)
                return HandRankings.FullHouse;
            else
                return base.Rank(hand, currentRank);
        }
    }
}
