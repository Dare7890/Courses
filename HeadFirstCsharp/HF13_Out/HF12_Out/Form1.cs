﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HF12_Out
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        public int ReturnThreeValues(out double half, out int twice)
        {
            int value = random.Next(1000);
            half = ((double)value) / 2;
            twice = value * 2;
            return value;
        }

        public void ModifyAnIntAndButton(ref int value, ref Button button)
        {
            int i = value;
            i *= 5;
            value = i - 3;
            button = button1;
        }

        public void CheckTemperature(double temperature, double tooHigh = 99.5, 
            double tooLow = 96.5)
        {
            if (temperature < tooHigh && temperature > tooLow)
                Console.WriteLine("Чувствую себя хорошо");
            else
                Console.WriteLine("Вызовите врача");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            double b;
            int c;
            a = ReturnThreeValues(out b, out c);
            Console.WriteLine("value = {0}, half = {1}, twice = {2}", a, b, c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int q = 100;
            Button b = button1;
            ModifyAnIntAndButton(ref q, ref b);
            Console.WriteLine("q = {0}, b.Text = {1}", q, b.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckTemperature(101.3);
            CheckTemperature(101.3, 102.5, 100.5);
            CheckTemperature(96.2, tooLow: 95.5);
        }
    }
}
