﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HF09_SimpleTextEditor
{
    public partial class Form1 : Form
    {
        private string name;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                textBox1.Clear();
                textBox1.Text = File.ReadAllText(name);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Сохранить как...";
            saveFileDialog1.InitialDirectory = @"D:\Work\C# projects\HF09_SimpleTextEditor";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                File.WriteAllText(name, textBox1.Text);
            }
        }
    }
}
