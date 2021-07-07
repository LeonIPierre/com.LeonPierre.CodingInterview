using System;
using System.Collections.Generic;
using System.Linq;

namespace com.LeonPierre.CodingInterview.Core
{
    public class Deck
    {
        public List<Card> Cards { get; set; } = new List<Card>();

        protected Random Random = new Random();

        public Deck()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                    Cards.Add(new Card(suit, value));
                }
            }
        }

        public IEnumerable<Card> Draw(int count)
        {
            if (count > Cards.Count)
                throw new Exception($"Cannot draw {count} cards deck only has ${Cards.Count} left");

            var cardsDrawn = Cards.Take(count);
            Cards.RemoveRange(0, count);
            return cardsDrawn;
        }

        public void Shuffle()
        {
            for (int i = 0; i < Cards.Count; i++)
            {
                int index = Random.Next(i, Cards.Count);
                Card temp = Cards[index];
                Cards[index] = Cards[i];
                Cards[i] = temp;
            }
        }

        public override string ToString()
        {
            return Cards.ToString();
        }
    }
}
