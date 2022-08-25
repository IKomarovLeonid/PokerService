namespace Domain.Src.Cards
{
    public class Card
    {
        public Suit Suit { get; }
        public CardValue Value { get; }

        public Card(Suit suit, CardValue cardValue)
        {
            Suit = suit;
            Value = cardValue;
        }
    }
}
