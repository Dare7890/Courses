using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HF02_WorkingWithVariables
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            string name = "Quentin";
            int x = 3;
            x *= 17;
            double d = Math.PI / 2;
            myLabel.Text = "name is " + name
                + "\nx is " + x
                + "\nd is " + d; 
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 5; 
            if (x == 5)
            {
                myLabel.Text = "x must be 10";
            }
            else
            {
                myLabel.Text = "x isn't 10";
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 3;
            string name = "Joe";
            if ((someValue == 3) && (name == "Joe"))
            {
                myLabel.Text = "x is 3 and the name is Joe";
            }
            myLabel.Text = "this line runs no matter what";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;

            while (count < 10)
            {
                count++;
            }

            for (int i = 0; i < 5; i++)
            {
                count--;
            }

            myLabel.Text = "The answer is " + count;
        }
    }
}
