using System.Collections.Generic;
using System.Linq;

namespace com.LeonPierre.CodingInterview.Core
{
    public class ThreeOfAKindRanking : PlayerHandRankerBase
    {
        public override HandRankings Rank(IEnumerable<Card> hand, HandRankings currentRank = HandRankings.None)
        {
            if (hand.GroupBy(h => h.Value)
                       .Where(g => g.Count() == 3).Any())
                return HandRankings.ThreeOfAKind;
            else
                return base.Rank(hand, currentRank);
        }
    }
}
