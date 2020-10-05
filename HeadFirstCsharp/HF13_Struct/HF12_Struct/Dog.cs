using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF12_Struct
{
    struct Dog
    {
        public string Name;
        public string Breed;

        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public void Speak()
        {
            Console.WriteLine("Меня зовут {0} и я {1}.", Name, Breed);
        }
    }
}
