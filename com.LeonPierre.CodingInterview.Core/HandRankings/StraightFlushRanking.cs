﻿using System.Collections.Generic;
using System.Linq;

namespace com.LeonPierre.CodingInterview.Core
{
    public class StraightFlushRanking : PlayerHandRankerBase
    {
        public override HandRankings Rank(IEnumerable<Card> hand, HandRankings currentRank = HandRankings.None)
        {
            var isFlush = hand.GroupBy(h => h.Suit).Count() == 1;

            if(!isFlush)
                return base.Rank(hand, currentRank);

            var ordered = hand.OrderBy(x => x.Value).ToArray();
    
            var firstCard = (int)ordered.First().Value;
            for (var i = 1; i < ordered.Length; i++)
            {
                if ((int)ordered[i].Value != firstCard + i)
                    return base.Rank(hand, currentRank);
            }

            return HandRankings.StraightFlush;
        }
    }
}
