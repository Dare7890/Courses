using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF08_SortCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random =new Random();
            int randomValue = 0;
            int randomSuit = 0;

            List<Card> cards = new List<Card>();

            for (int i = 0; i < 5; i++)
            {
                randomValue = random.Next(1, 14);
                randomSuit = random.Next(4);
                cards.Add(new Card((Suits)randomSuit, (Value)randomValue));
            }
            foreach (var card in cards)
            {
                Console.WriteLine(card);
            }
            CardComparer_byValue cardComparer = new CardComparer_byValue();
            cards.Sort(cardComparer);
            Console.WriteLine();
            foreach (var card in cards)
            {
                Console.WriteLine(card);
            }
            Console.ReadKey();
        }
    }
}
