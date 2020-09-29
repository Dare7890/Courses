using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HF09_StreamReaderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = @"D:\Work\C# projects\HF09_StreamWriter";
            StreamReader streamReader = new StreamReader(folder + @"\example.txt");
            StreamWriter streamWriter = new StreamWriter(folder + @"\email.txt");

            streamWriter.WriteLine("To: CaptainAmazing@objectville.net");
            streamWriter.WriteLine("From: Commissioner@objectville.net");
            streamWriter.WriteLine("Subject: Can you save the day... again?");
            streamWriter.WriteLine();
            streamWriter.WriteLine("We've discovered the Swindler's plan:");
            while (!streamReader.EndOfStream)
            {
                streamWriter.WriteLine("The plan -> " + streamReader.ReadLine());
            }
            streamWriter.WriteLine();
            streamWriter.WriteLine("Can you help us?");
            streamWriter.Close();
            streamReader.Close();
            Console.ReadKey();
        }
    }
}
