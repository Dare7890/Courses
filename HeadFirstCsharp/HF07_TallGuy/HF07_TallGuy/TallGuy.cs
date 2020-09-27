using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF07_TallGuy
{
    class TallGuy : IClown
    {
        public string Name;
        public int Height;

        public string FunnyThingIHave
        {
            get
            {
                return "Большие ботинки";
            }
        }

        public void Honk() => Console.WriteLine("Honk honk!");

        public void TalkAboutYourslf()
        {
            Console.WriteLine("My name is " + Name + " and I'm " + Height + " inches tall.");
        }
    }
}
