﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HF11_GuySerializer
{
    class Guy
    {
        public string Name;
        public int Cash;

        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                //MessageBox.Show("У меня не хватает денег " + amount,
                  //  Name + "говорит...");
                return 0;
            }
        }

        public int RecieveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                //MessageBox.Show(amount + " мне не нужно",
                //    Name + " говорит...");
                return 0;
            }
        }
    }
}
