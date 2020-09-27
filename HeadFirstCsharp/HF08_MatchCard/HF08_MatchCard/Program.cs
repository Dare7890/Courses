using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF08_MatchCard
{
    class Program
    {
        public static bool DoesCardMatch(Card cardToCheck, Suit suit)
        {
            if (cardToCheck.Suit == suit)
                return true;
            else
                return false;
        }

        public static bool DoesCardMatch(Card cardToCheck, Value value)
        {
            if (cardToCheck.Value == value)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Card card = new Card(Suit.Clubs, Value.Four);
            bool doesIsMatch = DoesCardMatch(card, Value.Four);
            Console.WriteLine(doesIsMatch);
            Console.ReadKey();
        }
    }
}
