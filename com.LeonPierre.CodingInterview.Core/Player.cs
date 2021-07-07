using System.Collections.Generic;
using System.Linq;

namespace com.LeonPierre.CodingInterview.Core
{
    public class Player
    {
        public string Name { get; private set; }

        public List<Card> Hand { get; private set; }

        public Player(string name, IEnumerable<Card> hand)
        {
            Name = name;
            Hand = hand.ToList();
        }

        public void AddToHand(IEnumerable<Card> cards)
        {
            Hand.AddRange(cards);
        }
    }
}
