using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExtensions;

namespace HF13_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Привет, мир, Помогите!";
            message.IsDistressCall();
        }
    }
}
