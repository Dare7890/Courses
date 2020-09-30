using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace HF10_GoFishWPF
{
    class Game : INotifyPropertyChanged
    {
        private List<Player> players;
        private Dictionary<Value, Player> books;
        private Deck stock;
        public string PlayerName { get; set; }
        public ObservableCollection<string> Hand { get; private set; }
        public string Books { get { return DescribeBooks(); } }
        public string GameProgress { get; private set; }
        public bool GameInProgress { get; private set; }
        public bool GameNotStarted { get { return !GameInProgress; } }

        public event PropertyChangedEventHandler PropertyChanged;

        public Game()
        {
            PlayerName = "Ed";
            Hand = new ObservableCollection<string>();
            ResetGame();
        }

        public void AddProgress(string progress)
        {
            GameProgress = progress + Environment.NewLine + GameProgress;
            OnPropertyChanged("GameProgress");
        }

        public void ClearProgress()
        {
            GameProgress = String.Empty;
            OnPropertyChanged("GameProgress");
        }

        public void StartGame()
        {
            ClearProgress();
            GameInProgress = true;
            OnPropertyChanged("GameInProgress");
            OnPropertyChanged("GameNotStarted");
            Random random = new Random();
            players = new List<Player>();
            players.Add(new Player(PlayerName, random, this));
            players.Add(new Player("Bob", random, this));
            players.Add(new Player("Joe", random, this));
            Deal();
            players[0].SortHand();
            Hand.Clear();
            foreach (String cardName in GetPlayerCardNames())
                Hand.Add(cardName);
            if (!GameInProgress)
                AddProgress(DescribePlayerHands());
            OnPropertyChanged("Books");
        }

        public void ResetGame()
        {
            GameInProgress = false;
            OnPropertyChanged("GameInProgress");
            OnPropertyChanged("GameNotStarted");
            books = new Dictionary<Value, Player>();
            stock = new Deck();
            Hand.Clear();
        }

        private void Deal()
        {
            stock.Shuffle();
            for (int i = 0; i < 5; i++)
            {
                foreach (var player in players)
                {
                    player.TakeCard(stock.Deal());
                }
            }
            foreach (var player in players)
            {
                player.PullOutBooks();
            }
        }

        public void PlayOneRound(int selectedPlayerCard)
        {
            Value cardToAskFor = players[0].Peek(selectedPlayerCard).Value;
            for (int i = 0; i < players.Count; i++)
            {
                if (i == 0)
                    players[0].AskForACard(players, 0, stock, cardToAskFor);
                else
                    players[i].AskForACard(players, i, stock);
                if (PullOutBooks(players[i]))
                {
                    AddProgress(players[i].Name + " drew a new hand\n");
                    int card = 1;
                    while (card <= 5 && stock.Count > 0)
                    {
                        players[i].TakeCard(stock.Deal());
                        card++;
                    }
                }
                OnPropertyChanged("Books");
                players[0].SortHand();
                if (stock.Count == 0)
                {
                    AddProgress("The stock is out of cards. Game over!");
                    ResetGame();
                    return;
                }
            }
            Hand.Clear();
            foreach (String cardName in GetPlayerCardNames())
                Hand.Add(cardName);
            if (!GameInProgress)
                AddProgress(DescribePlayerHands());
        }

        private void OnPropertyChanged(string property)
        {
            PropertyChangedEventHandler propertyChangedEvent = PropertyChanged;
            if (propertyChangedEvent != null)
            {
                propertyChangedEvent(this, new PropertyChangedEventArgs(property));
            }
        }

        private bool PullOutBooks(Player player)
        {
            var book = player.PullOutBooks();
            foreach (var value in book)
                books.Add(value, player);
            if (player.CardCount == 0)
                return true;
            return false;
        }

        public string DescribeBooks()
        {
            string whoHasWhichBooks = "";
            foreach (var value in books.Keys)
                whoHasWhichBooks += books[value].Name + " has a book of "
                    + Card.Plural(value) + "\n";
            return whoHasWhichBooks;
        }


        public IEnumerable<string> GetPlayerCardNames()
        {
            return players[0].GetCardNames();
        }

        public string DescribePlayerHands()
        {
            string description = "";
            for (int i = 0; i < players.Count; i++)
            {
                description += players[i].Name + " has " + players[i].CardCount;
                if (players[i].CardCount == 1)
                    description += " card." + Environment.NewLine;
                else
                    description += " cards." + Environment.NewLine;
            }
            description += "The stock has " + stock.Count + " cards left.";
            return description;
        }

        public string GetWinnerName()
        {
            Dictionary<string, int> winners = new Dictionary<string, int>();
            foreach (var value in books.Keys)
            {
                string name = books[value].Name;
                if (winners.ContainsKey(name))
                {
                    winners[name]++;
                }
                else
                {
                    winners.Add(name, 1);
                }
            }
            int maxCount = 0;
            foreach (var values in winners.Keys)
            {
                if (winners[values] > maxCount)
                    maxCount = winners[values];
            }
            bool pat = false;
            string winnerList = "";
            foreach (var values in winners.Keys)
            {
                if (maxCount == winners[values])
                {
                    if (!String.IsNullOrEmpty(winnerList))
                    {
                        winnerList += " and ";
                        pat = true;
                    }
                    winnerList += values;
                }
            }
            winnerList += " with " + maxCount + " books";
            if (pat)
                return "A tie between " + winnerList;
            else
                return winnerList;
        }

    }
}
