using System.Collections.Generic;
using System.Linq;

namespace com.LeonPierre.CodingInterview.Core
{
    public class FourOfAKindHandRanking : PlayerHandRankerBase
    {
        public override HandRankings Rank(IEnumerable<Card> hand, HandRankings currentRank = HandRankings.None)
        {
            if (hand.GroupBy(h => h.Value)
                       .Where(g => g.Count() == 2).Any())
                return HandRankings.FourOfAKind;
            else
                return base.Rank(hand, currentRank);
        }
    }
}
