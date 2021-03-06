﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWithJoeAndBob
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " имеет $" + joe.Cash;
            bobsCashLabel.Text = bob.Name + " имеет $" + bob.Cash;
            bankCashLabel.Text = "В банке сейчас $" + bank;
        }

        public Form1()
        {
            InitializeComponent();
            joe = new Guy() { Cash = 50, Name = "Joe" };

            bob = new Guy() { Name = "Bob", Cash = 100 };

            UpdateForm();
        }

        private void btnGive_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.RecieveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("В банке нет денег");
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            bob.Cash += joe.GiveCash(10);
            UpdateForm();
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            joe.Cash += bob.GiveCash(5);
            UpdateForm();
        }
    }
}
