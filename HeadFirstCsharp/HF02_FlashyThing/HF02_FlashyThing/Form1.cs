using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HF02_FlashyThing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            while (Visible)
            {
                int i = 0;
                while(i < 254 && Visible)
                {
                    this.BackColor = Color.FromArgb(i, 255 - i, i);

                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                    i++;
                }

                while (i > 0 && Visible)
                {
                    this.BackColor = Color.FromArgb(i, 255 - i, i);

                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                    i--;
                }
            }
        }
    }
}
