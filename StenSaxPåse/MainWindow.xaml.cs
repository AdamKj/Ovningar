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
            int result = 1;

            if (_playerPicks == "Sten" && _computer == "Påse") // Player: Sten, Computer: Påse = Computer vann
            {
                MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computer}. {_compWins}", "Resultat");
            }
            else if (_playerPicks == "Sten" && _computer == "Sax") // Player: Sten, Computer: Sax = Player vann
            {
                MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computer}. {_playerWins}", "Resultat");
                result = Convert.ToInt32(Resultat.Content);
            }
            else if (_playerPicks == "Påse" && _computer == "Sax") // Player: Påse, Computer: Sax = Computer vann
            {
                MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computer}. {_compWins}", "Resultat");

            }
            else if (_playerPicks == "Påse" && _computer == "Sten") // Player: påse, Computer: Sten = Player vann
            {
                MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computer}. {_playerWins}", "Resultat");
                Resultat.Content += result.ToString();

            }
            else if (_playerPicks == "Sax" && _computer == "Sten") // Player: Sax, Computer: Sten = Computer vann
            {
                MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computer}. {_compWins}", "Resultat");

            }
            else if (_playerPicks == "Sax" && _computer == "Påse") // Player: Sax, Computer: Påse = Player vann
            {
                MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computer}. {_playerWins}", "Resultat");
                Resultat.Content += result.ToString();

            }
            if (_playerPicks == "Sax" && _computer == "Sax")
            {
                MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computer}. {_draw}", "Resultat");

            }
            else if (_playerPicks == "Påse" && _computer == "Påse")
            {
                MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computer}. {_draw}", "Resultat");
            }
            else if (_playerPicks == "Sten" && _computer == "Sten")
            {
                MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computer}. {_draw}", "Resultat");
            }
        }
    }
}
