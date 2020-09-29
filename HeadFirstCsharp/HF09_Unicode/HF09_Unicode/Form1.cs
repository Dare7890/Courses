using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HF09_Unicode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Eureka!";
            File.WriteAllText("eureka.txt", str);
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            foreach (var bytes in eurekaBytes)
            {
                Console.WriteLine("{0}", bytes);
            }
            Console.WriteLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            foreach (var bytes in eurekaBytes)
            {
                Console.Write("{0:x2}", bytes);
            }
            Console.WriteLine();
        }
    }
}
