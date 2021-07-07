namespace com.LeonPierre.CodingInterview.Core
{
    public enum Suit
    {
        Heart,
        Spade,
        Diamond,
        Club
    }

    public enum CardValue
    {
        Two
        ,Three
        ,Four
        ,Five
        ,Six
        ,Seven
        ,Eight
        ,Nine
        ,Ten
        ,Jack
        ,ueen
        ,King
        ,Ace
    }

    public enum HandRankings
    {
        None,
        HighCard,
        Pair,
        TwoPair,
        ThreeOfAKind,
        Straight,
        Flush,
        FullHouse,
        FourOfAKind,
        StraightFlush
    }

    public class Card
    {
        public Suit Suit { get; private set; }

        public CardValue Value { get; private set; }

        public Card(Suit suit, CardValue value)
        {
            Suit = suit;
            Value = value;
        }

        public override bool Equals(object obj)
        {
            Card other = obj as Card;
            return other != null && other.Suit == Suit && other.Value == Value;
        }

        public override int GetHashCode()
        {
            return Suit.GetHashCode() + Value.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Suit} of {Value}";
        }
    }
}
