using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF07_TallGuy
{
    class FunnyFunny : IClown
    {
        protected string funnyThingIHave;

        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        public string FunnyThingIHave
        {
            get
            {
                return "Привет! У меня есть " + funnyThingIHave;
            }
        }

        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIHave);
        }
    }
}
