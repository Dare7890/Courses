using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HF04_Elephant
{
    public partial class Form1 : Form
    {
        Elephant lloyd, lucinda;

        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lloyd = new Elephant() { Name = "lloyd", EarSize = 40 };
        }

        private void btnLloyd_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            Elephant newElephant = lucinda;
            lucinda = lloyd;
            lloyd = lucinda;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.TellMe("Hello", lucinda);
            lloyd.SpeakTo(lucinda, "Hi");
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }

        private void btnLucinda_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }
    }
}
