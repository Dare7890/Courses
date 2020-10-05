using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HF12_Finalizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCln1_Click(object sender, EventArgs e)
        {
            using(Clone clone = new Clone(1))
            {

            }
        }

        private void btnCln2_Click(object sender, EventArgs e)
        {
            Clone clone2 = new Clone(2);
            clone2 = null;
        }

        private void btnGC_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
