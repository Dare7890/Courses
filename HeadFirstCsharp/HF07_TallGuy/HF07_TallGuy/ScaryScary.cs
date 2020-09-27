using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF07_TallGuy
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        private int numberOfScaryThings;

        public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        public string ScaryThingIHave
        {
            get
            {
                return numberOfScaryThings + " пауков";
            }
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine("Ты не можешь забрать " + base.funnyThingIHave);
        }
    }
}
