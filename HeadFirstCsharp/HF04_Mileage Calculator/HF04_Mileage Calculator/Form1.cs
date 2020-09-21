using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HF04_Mileage_Calculator
{
    public partial class Form1 : Form
    {
        int startingMileage = default;
        int endingMileage = default;
        double milesTraveled = default;
        double reimburseRate = .39D;
        double amountOwed = default;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            startingMileage = (int)nudStart.Value;
            endingMileage = (int)nudEnd.Value;
            if (startingMileage < endingMileage)
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                lblResult.Text = "$" + amountOwed;
            }
            else
            {
                MessageBox.Show("Начальный пробег не может превышать конечный", "Cannot Calculate");
            }
        }

        private void btnDisplayMiles_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + "miles", "Miles Traveled");
        }
    }
}
