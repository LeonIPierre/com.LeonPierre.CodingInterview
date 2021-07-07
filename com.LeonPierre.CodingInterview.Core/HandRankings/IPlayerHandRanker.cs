using System.Collections.Generic;

namespace com.LeonPierre.CodingInterview.Core
{
    public interface IPlayerHandRanker
    {
        IPlayerHandRanker SetNext(IPlayerHandRanker handler);

        HandRankings Rank(IEnumerable<Card> hand, HandRankings currentRank = HandRankings.None);
    }

    public abstract class PlayerHandRankerBase : IPlayerHandRanker
    {
        protected IPlayerHandRanker NextHandler;

        public virtual IPlayerHandRanker SetNext(IPlayerHandRanker handler)
        {
            NextHandler = handler;
            
            return handler;
        }

        public virtual HandRankings Rank(IEnumerable<Card> hand, HandRankings currentRank = HandRankings.None)
        {
            if (NextHandler != null)
                return NextHandler.Rank(hand, currentRank);
            else
                return HandRankings.None;
        }
    }
}
