using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF08_Birds
{
    class Penguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Пингвины не летают");
        }

        public override string ToString()
        {
            return "Имя пингвина " + Name;
        }
    }
}
