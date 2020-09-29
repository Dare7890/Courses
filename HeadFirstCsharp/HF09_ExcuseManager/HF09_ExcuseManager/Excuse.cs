using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace HF09_ExcuseManager
{
    [Serializable]
    class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }

        public Excuse()
        {
            ExcusePath = "";
        }

        public Excuse(string excusePath)
        {
            OpenFile(excusePath);
        }

        public Excuse(Random random, string path)
        {
            string[] files = Directory.GetFiles(path + "*.txt");
            OpenFile(files[random.Next(files.Length)]);
        }

        public void OpenFile(string file)
        {
            this.ExcusePath = file;
            BinaryFormatter binary = new BinaryFormatter();
            using (FileStream input = File.OpenRead(file + @"\Excuse"))
            {
                Excuse newExcuse = (Excuse)binary.Deserialize(input);
                Description = newExcuse.Description;
                Results = newExcuse.Results;
                LastUsed = newExcuse.LastUsed;
            }
        }

        public void Save(string file)
        {
            BinaryFormatter binary = new BinaryFormatter();
            using (FileStream output = File.Create(file + @"\Excuse"))
            {
                binary.Serialize(output, this);
            }
        }
    }
}
