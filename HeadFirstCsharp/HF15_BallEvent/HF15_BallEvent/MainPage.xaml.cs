﻿using System;
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

namespace HF15_BallEvent
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        BaseballSimulator baseballSimulator;

        public MainPage()
        {
            InitializeComponent();
            baseballSimulator = FindResource("baseballSimulator") as BaseballSimulator;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            baseballSimulator.PlayBall();
        }
    }
}
