using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HF09_ExcuseManager
{
    public partial class Form1 : Form
    {
        Excuse currentExcuse = new Excuse();
        Random random = new Random();
        private bool formChanged = false;
        private string selectedFolder = "";

        public Form1()
        {
            InitializeComponent();
            btnOpen.Visible = false;
            btnRandom.Visible = false;
            btnSave.Visible = false;
            currentExcuse.LastUsed = dtpLastUsed.Value;
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.tbExcuse.Text = currentExcuse.Description;
                this.tbResults.Text = currentExcuse.Results;
                this.dtpLastUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                    lblFileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                this.Text = "Excuse Manager";
            }
            else
                this.Text = "Excuse Manager*";
            this.formChanged = changed;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbExcuse.Text) || String.IsNullOrEmpty(tbResults.Text))
            {
                MessageBox.Show("Please specify an excuse and a result",
                     "Unable to save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            lblFileDate.Text = DateTime.Now.ToString();
            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Class Excuse (*.excuse)|*.excuse|All files(*.*)|*.*";
            saveFileDialog1.Title = "Save as";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Excuse written");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            lblFileDate.Text = DateTime.Now.ToString();
            openFileDialog1.InitialDirectory = selectedFolder;
            openFileDialog1.Filter = "Class Excuse (*.excuse)|*.excuse|All files(*.*)|*.*";
            openFileDialog1.Title = "Open file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentExcuse = new Excuse(openFileDialog1.FileName);
                UpdateForm(false);
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                btnOpen.Visible = true;
                btnRandom.Visible = true;
                btnSave.Visible = true;
            }
        }

        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show(
                      "The current excuse has not been saved. Continue?",
                       "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return false;
            }
            return true;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }

        private void tbExcuse_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = tbExcuse.Text;
            UpdateForm(true);
        }

        private void tbResults_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = tbResults.Text;
            UpdateForm(true);
        }

        private void dtpLastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = dtpLastUsed.Value;
            UpdateForm(true);
        }
    }
}
