using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF12_RobustGuy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите дату рождения: ");
            string birthday = Console.ReadLine();
            Console.Write("Укажите рост в дюймах: ");
            string height = Console.ReadLine();
            RobustGuy guy = new RobustGuy(birthday, height);
            Console.WriteLine(guy.ToString());
            Console.ReadKey();
        }
    }
}
