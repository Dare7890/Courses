using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace HF09_Cards
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private Deck RandomDeck(int number)
        {
            Deck myDeck = new Deck(new Card[] { });
            for (int i = 0; i < number; i++)
            {
                myDeck.Add(new Card((Suit)random.Next(4), (Value)random.Next(1, 14)));
            }
            return myDeck;
        }

        private void DealCards(Deck deckToDeal, string title)
        {
            Console.WriteLine(title);
            while (deckToDeal.Count > 0)
            {
                Card nextCard = deckToDeal.Deal(0);
                Console.WriteLine(nextCard.Name);
            }
            Console.WriteLine("------------------");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string path = @"D:\Work\C# projects\HF09_Cards";
            using (Stream input = File.OpenRead(path + @"\Deck.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Deck myDeck = (Deck)formatter.Deserialize(input);
                DealCards(myDeck, "Что было прочитано из файла");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string path = @"D:\Work\C# projects\HF09_Cards";
            Deck myDeck = RandomDeck(5);
            using(Stream output = File.Create(path + @"\Deck.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, myDeck);
            }
            DealCards(myDeck, "Что было записано в файл");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"D:\Work\C# projects\HF09_Cards";
            using (Stream output = File.Create(path + @"\Deck2.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                for (int i = 1; i < 6; i++)
                {
                    Deck myDeck = RandomDeck(random.Next(1, 10));
                    formatter.Serialize(output, myDeck);
                    DealCards(myDeck, "Колода #" + i + " записана");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:\Work\C# projects\HF09_Cards";
            using (Stream input = File.OpenRead(path + @"\Deck2.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                for (int i = 1; i < 6; i++)
                {
                    Deck myDeck = (Deck)formatter.Deserialize(input);
                    DealCards(myDeck, "Колода #" + i + " прочитана");
                }
            }
        }
    }
}
