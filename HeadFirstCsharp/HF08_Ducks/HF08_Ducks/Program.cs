using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF08_Ducks
{
    class Program
    {
        public static void PrintDucks (List<Duck> list)
        {
            foreach( var duck in list)
                Console.WriteLine(duck);
            Console.WriteLine("Утки кончились!");
        }

        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17},
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18},
                new Duck() { Kind = KindOfDuck.Decoy, Size = 14},
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11},
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14},
                new Duck() { Kind = KindOfDuck.Decoy, Size = 13},
            };

            DuckComparerBySize sizeComparer = new DuckComparerBySize();
            DuckComparerByKind kindCompare = new DuckComparerByKind();

            Duck[] duckArray = new Duck[6];
            duckArray.GetEnumerator();

            PrintDucks(ducks);
            ducks.Sort(kindCompare);
            PrintDucks(ducks);
            Console.ReadKey();
        }
    }
}
