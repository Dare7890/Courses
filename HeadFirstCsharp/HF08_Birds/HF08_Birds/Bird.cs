using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF08_Birds
{
    class Bird
    {
        public string Name { get; set; }
        public virtual void Fly()
        {
            Console.WriteLine("Полетели!");
        }
        public override string ToString()
        {
            return "Имя птицы " + Name; 
        }
    }
}
