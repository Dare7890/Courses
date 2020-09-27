using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF08_Birds
{
    class Program
    {
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

            List<Bird> birds = new List<Bird>();

            birds.Add(new Bird() { Name = "Пернатые" });
            birds.AddRange(ducks);
            birds.Add(new Penguin() { Name = "Джордж" });

            foreach (var bird in birds)
                Console.WriteLine(bird);
            Console.ReadKey();
        }
    }
}
