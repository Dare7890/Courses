using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HF06_Constructor
{
    public partial class Form1 : Form
    {
        MyBaseClass baseClass;
        MySubclass subclass;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baseClass = new MyBaseClass("Form1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            subclass = new MySubclass("Subclass", 4);
        }
    }
}
