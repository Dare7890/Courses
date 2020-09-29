﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HF09_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"D:\Work\C# projects\HF09_StreamWriter\example.txt");
            sw.WriteLine("How I'LL defeat Captain Amazing");
            sw.WriteLine("Another genius secret plan by The Swindler");
            sw.Write("I'll create an army of clones and ");
            sw.WriteLine("unleash them upon the citizens of Objectville.");

            string location = "the mall";

            for (int number = 0; number < 7; number++)
            {
                sw.WriteLine("Clone #{0} attacks {1}", number, location);
                if (location == "the mall")
                    location = "downTown";
                else
                    location = "the mall";
            }
            sw.Close();
            Console.ReadKey();
        }
    }
}
