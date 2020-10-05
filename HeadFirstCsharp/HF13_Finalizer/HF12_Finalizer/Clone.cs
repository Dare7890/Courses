using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace HF12_Finalizer
{
    [Serializable]
    class Clone : IDisposable
    {
        public int Id { get; private set; }

        public Clone(int id)
        {
            Id = id;
        }

        public void Dispose()
        {
            string filename = @"C:\Temp\Clone.dat";
            string dirname = @"C:\Temp";
            if (File.Exists(filename) == false)
                Directory.CreateDirectory(dirname);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (Stream output = File.OpenWrite(filename))
                binaryFormatter.Serialize(output, this);

            MessageBox.Show("Должен сериализовать объект", "Clone #" + Id + " says...");
        }

        ~Clone()
        {
            MessageBox.Show("Aaargh! You got me!", "Clone #" + Id + " says...");
        }
    }
}
