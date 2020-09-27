using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF08_Deck
{
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)
                    cards.Add(new Card((Suit)suit, (Value)value));
            }
        }

        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        public int Count
        {
            get
            {
                return cards.Count;
            }
        }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal (int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }

        public void Sort()
        {
            cards.Sort(new CardComparer_bySuit());
        }

        public void Shuffle()
        {
            List<Card> newDeck = new List<Card>();
            while(cards.Count > 0)
            {
                int numberOfCard = random.Next(cards.Count);
                newDeck.Add(cards.ElementAt(numberOfCard));
                cards.RemoveAt(numberOfCard);
            }
            cards = newDeck;
        }

        public IEnumerable<string> GetCardNames()
        {
            string[] cardsName = new string[cards.Count];
            for (int i = 0; i < cardsName.Length; i++)
            {
                cardsName[i] = cards[i].Name;
            }
            return cardsName;
        }
    }
}
