using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HF04_MenuMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MenuMarket menuMarket = new MenuMarket() { Randomizer = new Random() };
            label1.Text = menuMarket.GetMenuItem();
            label2.Text = menuMarket.GetMenuItem();
            label3.Text = menuMarket.GetMenuItem();
            label4.Text = menuMarket.GetMenuItem();
            label5.Text = menuMarket.GetMenuItem();
            label6.Text = menuMarket.GetMenuItem();
        }
    }
}
