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

namespace HF10_GoFishWPF
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        Game game;
        public MainPage()
        {
            InitializeComponent();
            game = this.FindResource("game") as Game;
        }

        private void AskForACard_Click(object sender, RoutedEventArgs e)
        {
            if (cards.SelectedIndex >= 0)
                game.PlayOneRound(cards.SelectedIndex);
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            game.StartGame();
        }

        private void cards_DoubleTapped(object sender, MouseButtonEventArgs e)
        {
            if (cards.SelectedIndex >= 0)
                game.PlayOneRound(cards.SelectedIndex);
        }
    }
}
