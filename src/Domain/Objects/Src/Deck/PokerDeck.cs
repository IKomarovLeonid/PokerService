using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Src.Cards;

namespace Objects.Src.Deck
{
    public class PokerDeck
    {
        private readonly IDictionary<CardValue, ICollection<Card>> _cards;

        public PokerDeck()
        {
            _cards = new Dictionary<CardValue, ICollection<Card>>();
        }

        public void InitializeDeck()
        {
            _cards.Clear();

            var suits = (Suit[])Enum.GetValues(typeof(Suit));
            var cardValues = (CardValue[])Enum.GetValues(typeof(CardValue));

            foreach (var cardValue in cardValues)
            {
                var list = new List<Card>();

                foreach (var suit in suits)
                {
                    list.Add(new Card(suit, cardValue));
                }

                _cards.Add(cardValue, list);
            }
        }

        public Card GetCardOrDefault()
        {
            var rnd = new Random();

            Card card = null;

            while (!IsEmpty())
            {
                var cardValue = (CardValue)rnd.Next(1, 14);

                if (_cards[cardValue].Count == 0) continue;

                var suit = (Suit)rnd.Next(1, 5);

                var foundCard = _cards[cardValue].FirstOrDefault(t => t.Suit == suit);

                if (foundCard != null)
                {
                    card = foundCard;
                    _cards[cardValue].Remove(foundCard);
                    break;
                }
            }

            return card;
        }

        public Card GetConcreteCard(CardValue value, Suit suit)
        {
            _cards.TryGetValue(value, out var cards);

            return cards.First(t => t.Suit == suit);
        }

        private bool IsEmpty()
        {
            return _cards.Values.Sum(list => list.Count) == 0;
        }
    }
}
