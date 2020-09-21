using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HF04_BouncingLabels
{
    public partial class Form1 : Form
    {
        LabelBouncher[] labelBouncher = new LabelBouncher[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void ToggleBouncing(int index, Label label)
        {
            if (labelBouncher[index] == null)
            {
                labelBouncher[index] = new LabelBouncher();
                labelBouncher[index].MyLabel = label;
            }
            else
            {
                labelBouncher[index] = null;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (labelBouncher[i] != null)
                    labelBouncher[i].Move();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleBouncing(0, label1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToggleBouncing(1, label2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToggleBouncing(2, label3);
        }
    }
}
