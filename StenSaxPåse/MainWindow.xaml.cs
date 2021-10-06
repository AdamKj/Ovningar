using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace StenSaxPåse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string _computer;
        string[] _computerChoice = { "Sten", "Sax", "Påse" };
        Random _random = new Random();
        int _randomType;
        string _playerPicks;

        Score score = new Score();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sten_Click(object sender, RoutedEventArgs e)
        {
            _playerPicks = "Sten";
            _randomType = _random.Next(0, 3);
            _computer = _computerChoice[_randomType];
            Game();
        }

        private void Sax_Click(object sender, RoutedEventArgs e)
        {
            _playerPicks = "Sax";
            _randomType = _random.Next(0, 3);
            _computer = _computerChoice[_randomType];
            Game();
        }

        private void Påse_Click(object sender, RoutedEventArgs e)
        {
            _playerPicks = "Påse";
            _randomType = _random.Next(0, 3);
            _computer = _computerChoice[_randomType];
            Game();
        }

        

        public void Game()
        {
            string _playerWins = "Du vann!";
            string _compWins = "Datorn vann..";
            string _draw = "Det blev oavgjort?!";

            if (_playerPicks == "Sten" && _computer == "Påse") // Player: Sten, Computer: Påse = Computer vann
            {
                MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computer}. {_compWins} {EndMessage()}", "Resultat", MessageBoxButton.OKCancel);
                MessageBoxChoice();
            }
            else if (_playerPicks == "Sten" && _computer == "Sax") // Player: Sten, Computer: Sax = Player vann
            {
                MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computer}. {_playerWins} {EndMessage()}", "Resultat", MessageBoxButton.OKCancel);
                ScoreUpdate();
                MessageBoxChoice();
            }
            else if (_playerPicks == "Påse" && _computer == "Sax") // Player: Påse, Computer: Sax = Computer vann
            {
                MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computer}. {_compWins} {EndMessage()}", "Resultat", MessageBoxButton.OKCancel);
                MessageBoxChoice();

            }
            else if (_playerPicks == "Påse" && _computer == "Sten") // Player: påse, Computer: Sten = Player vann
            {
                MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computer}. {_playerWins} {EndMessage()}", "Resultat", MessageBoxButton.OKCancel);
                ScoreUpdate();
                MessageBoxChoice();
            }
            else if (_playerPicks == "Sax" && _computer == "Sten") // Player: Sax, Computer: Sten = Computer vann
            {
                MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computer}. {_compWins} {EndMessage()}", "Resultat", MessageBoxButton.OKCancel);
                MessageBoxChoice();

            }
            else if (_playerPicks == "Sax" && _computer == "Påse") // Player: Sax, Computer: Påse = Player vann
            {
                MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computer}. {_playerWins} {EndMessage()}", "Resultat", MessageBoxButton.OKCancel);
                ScoreUpdate();
                MessageBoxChoice();
            }
            if (_playerPicks == "Sax" && _computer == "Sax")
            {
                MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computer}. {_draw} {EndMessage()}", "Resultat", MessageBoxButton.OKCancel);
                MessageBoxChoice();

            }
            else if (_playerPicks == "Påse" && _computer == "Påse")
            {
                MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computer}. {_draw} {EndMessage()}", "Resultat", MessageBoxButton.OKCancel);
                MessageBoxChoice();
            }
            else if (_playerPicks == "Sten" && _computer == "Sten")
            {
                MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computer}. {_draw} {EndMessage()}", "Resultat", MessageBoxButton.OKCancel);
                MessageBoxChoice();
            }
        }

        public void ScoreUpdate()
        {
            Resultat.Content = "Poäng: " + score.CurrentScore++;
        }

        public string EndMessage()
        {
            return "\nVill du spela igen?";
        }

        public void MessageBoxChoice()
        {
            MessageBoxResult result;

            switch (result)
            {
                case MessageBoxResult.OK:
                    break;
                case MessageBoxResult.Cancel:
                    Application.Current.Shutdown();
                    break;
            }
        }
    }
}
