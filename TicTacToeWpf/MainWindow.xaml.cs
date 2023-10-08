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

namespace TicTacToeWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public bool turn = true;
        public bool End = false;

        public string Turn(Button button)
        {
            if (turn)
            {
                turn = false;
                Textboxik.Text = "O";
                Textboxik.Background = Brushes.Green;
                return "X";
            }
            if (turn == false)
            {
                turn = true;
                Textboxik.Text = "X";
                Textboxik.Background = Brushes.Red;
                return "O";
            }
            return "X";
        }
        private void SetWinner(string winner)
        {
            FinishTextBox.Text = "Congratulations winner is: " + winner;
            End = true;
            EndGame();
            Restart.IsEnabled = true;
        }
        public void Check()
        {
            Restart.IsEnabled = false;
            string winner = "";

            if ((But1.Content == "X" && But2.Content == "X" && But3.Content == "X") ||
                (But4.Content == "X" && But5.Content == "X" && But6.Content == "X") ||
                (But7.Content == "X" && But8.Content == "X" && But9.Content == "X") ||
                (But1.Content == "X" && But5.Content == "X" && But9.Content == "X") ||
                (But3.Content == "X" && But5.Content == "X" && But7.Content == "X") ||
                (But1.Content == "X" && But4.Content == "X" && But7.Content == "X") ||
                (But2.Content == "X" && But5.Content == "X" && But8.Content == "X") ||
                (But3.Content == "X" && But6.Content == "X" && But9.Content == "X"))
            {
                winner = "X";
            }
            if ((But1.Content == "O" && But2.Content == "O" && But3.Content == "O") ||
                     (But4.Content == "O" && But5.Content == "O" && But6.Content == "O") ||
                     (But7.Content == "O" && But8.Content == "O" && But9.Content == "O") ||
                     (But1.Content == "O" && But5.Content == "O" && But9.Content == "O") ||
                     (But3.Content == "O" && But5.Content == "O" && But7.Content == "O") ||
                     (But1.Content == "O" && But4.Content == "O" && But7.Content == "O") ||
                     (But2.Content == "O" && But5.Content == "O" && But8.Content == "O") ||
                     (But3.Content == "O" && But6.Content == "O" && But9.Content == "O"))
            {
                winner = "O";
            }

            if (!string.IsNullOrEmpty(winner))
            {
                SetWinner(winner);
            } 
                Draw(); 
        }

        public void Draw()
        {
            if (But1.IsEnabled == false
                && But2.IsEnabled == false
                && But3.IsEnabled == false
                && But4.IsEnabled == false
                && But5.IsEnabled == false
                && But6.IsEnabled == false
                && But7.IsEnabled == false
                && But8.IsEnabled == false
                && But9.IsEnabled == false && End == false)
            {
                FinishTextBox.Text = "Draw";
                Restart.IsEnabled = true;
                End = true;
                EndGame();
            }
        }
        public void EndGame()
        {
            But1.IsEnabled = false;
            But2.IsEnabled = false;
            But3.IsEnabled = false;
            But4.IsEnabled = false;
            But5.IsEnabled = false;
            But6.IsEnabled = false;
            But7.IsEnabled = false;
            But8.IsEnabled = false;
            But9.IsEnabled = false;
        }
        private void Button_Restart(object sender, RoutedEventArgs e)
        {
            if (End = true)
            {
                But1.IsEnabled = true;
                But2.IsEnabled = true;
                But3.IsEnabled = true;
                But4.IsEnabled = true;
                But5.IsEnabled = true;
                But6.IsEnabled = true;
                But7.IsEnabled = true;
                But8.IsEnabled = true;
                But9.IsEnabled = true;
                But1.Content = "";
                But2.Content = "";
                But3.Content = "";
                But4.Content = "";
                But5.Content = "";
                But6.Content = "";
                But7.Content = "";
                But8.Content = "";
                But9.Content = "";
                FinishTextBox.Text = "New Game!";
                End = false;
            }
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            But1.Content = Turn(But1);
            But1.IsEnabled = false;
            Check();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {

            But2.Content = Turn(But2);
            But2.IsEnabled = false;
            Check();
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {

            But3.Content = Turn(But3);
            But3.IsEnabled = false;
            Check();
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            But4.Content = Turn(But4);
            But4.IsEnabled = false;
            Check();
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            But5.Content = Turn(But5);
            But5.IsEnabled = false;
            Check();
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            But6.Content = Turn(But6);
            But6.IsEnabled = false;
            Check();
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            But7.Content = Turn(But7);
            But7.IsEnabled = false;
            Check();
        }
        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            But8.Content = Turn(But8);
            But8.IsEnabled = false;
            Check();
        }
        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            But9.Content = Turn(But9);
            But9.IsEnabled = false;
            Check();
        }
    }
}
