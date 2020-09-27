using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HF08_Cards
{
    public partial class Form1 : Form
    {
        Card card;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectCard_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numberBetween0and3 = random.Next(4);
            int numberBetween1and13 = random.Next(1, 14);
            card = new Card((Suit)numberBetween0and3, (Value)numberBetween1and13);
            MessageBox.Show(card.Name);
        }
    }
}
