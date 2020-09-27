using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HF08_GoFish
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;

        public Player(String name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            this.cards = new Deck(new Card[] { });
            this.textBoxOnForm.Text += name + " has just joined the game\n";
        }

        public IEnumerable<Value> PullOutBooks()
        {
            List<Value> books = new List<Value>();
            for (int i = 1; i <= 13; i++)
            {
                Value value = (Value)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                    if (cards.Peek(card).Value == value)
                        howMany++;
                if (howMany == 4)
                {
                    books.Add(value);
                    cards.PullOutValues(value);
                }
            }
            return books;
        }

        public Value GetRandomValue()
        {
            Card card = cards.Peek(random.Next(cards.Count));
            return card.Value;
        }

        public Deck DoYouHaveAny(Value value)
        {
            Deck cardsIHave = cards.PullOutValues(value);
            textBoxOnForm.Text += name + " has " + cardsIHave.Count + " " + Card.Plural(value) + "\n";
            return cardsIHave;
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            if (stock.Count > 0)
            {
                if (cards.Count == 0)
                    cards.Add(stock.Deal());
            }
            Value randomCard = GetRandomValue();
            AskForACard(players, myIndex, stock, randomCard);
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Value randomCard)
        {
            textBoxOnForm.Text += name + " asks if anyone has a " + randomCard + "\n";
            int countNewCard = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    Player player = players[i];
                    Deck newDeck = player.DoYouHaveAny(randomCard);
                    countNewCard += newDeck.Count;
                    while (newDeck.Count > 0)
                        cards.Add(newDeck.Deal());
                }
            }
        }

        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }
    }
}
