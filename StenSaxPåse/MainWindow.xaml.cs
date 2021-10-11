using System;
using System.Windows;

namespace StenSaxPåse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _computerPicks;
        private string[] _computerChoice = { "Sten", "Sax", "Påse" };
        private Random _random = new Random();
        private int _randomType;
        private string _playerPicks;
        private MessageBoxResult _result;

        Score score = new Score();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sten_Click(object sender, RoutedEventArgs e)
        {
            _playerPicks = "Sten";
            _randomType = _random.Next(0, 3);
            _computerPicks = _computerChoice[_randomType];
            Game();
        }

        private void Sax_Click(object sender, RoutedEventArgs e)
        {
            _playerPicks = "Sax";
            _randomType = _random.Next(0, 3);
            _computerPicks = _computerChoice[_randomType];
            Game();
        }

        private void Påse_Click(object sender, RoutedEventArgs e)
        {
            _playerPicks = "Påse";
            _randomType = _random.Next(0, 3);
            _computerPicks = _computerChoice[_randomType];
            Game();
        }

        

        public void Game()
        {
            string _playerWins = "Du vann!";
            string _compWins = "Datorn vann..";
            string _draw = "Det blev oavgjort?!";

            if (_playerPicks == "Sten" && _computerPicks == "Påse") // Player: Sten, Computer: Påse = Computer vann
            {
                _result = MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computerPicks}. {_compWins} {EndMessage()}", "Resultat", MessageBoxButton.YesNo);
                ScoreUpdateComputer();
                MessageBoxChoice();
            }
            else if (_playerPicks == "Sten" && _computerPicks == "Sax") // Player: Sten, Computer: Sax = Player vann
            {
                _result = MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computerPicks}. {_playerWins} {EndMessage()}", "Resultat", MessageBoxButton.YesNo);
                ScoreUpdatePlayer();
                MessageBoxChoice();
            }
            else if (_playerPicks == "Påse" && _computerPicks == "Sax") // Player: Påse, Computer: Sax = Computer vann
            {
                _result = MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computerPicks}. {_compWins} {EndMessage()}", "Resultat", MessageBoxButton.YesNo);
                ScoreUpdateComputer();
                MessageBoxChoice();

            }
            else if (_playerPicks == "Påse" && _computerPicks == "Sten") // Player: påse, Computer: Sten = Player vann
            {
                _result = MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computerPicks}. {_playerWins} {EndMessage()}", "Resultat", MessageBoxButton.YesNo);
                ScoreUpdatePlayer();
                MessageBoxChoice();
            }
            else if (_playerPicks == "Sax" && _computerPicks == "Sten") // Player: Sax, Computer: Sten = Computer vann
            {
                _result = MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computerPicks}. {_compWins} {EndMessage()}", "Resultat", MessageBoxButton.YesNo);
                ScoreUpdateComputer();
                MessageBoxChoice();

            }
            else if (_playerPicks == "Sax" && _computerPicks == "Påse") // Player: Sax, Computer: Påse = Player vann
            {
                _result = MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computerPicks}. {_playerWins} {EndMessage()}", "Resultat", MessageBoxButton.YesNo);
                ScoreUpdatePlayer();
                MessageBoxChoice();
            }
            if (_playerPicks == "Sax" && _computerPicks == "Sax")
            {
                _result = MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computerPicks}. {_draw} {EndMessage()}", "Resultat", MessageBoxButton.YesNo);
                MessageBoxChoice();

            }
            else if (_playerPicks == "Påse" && _computerPicks == "Påse")
            {
                _result = MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computerPicks}. {_draw} {EndMessage()}", "Resultat", MessageBoxButton.YesNo);
                MessageBoxChoice();
            }
            else if (_playerPicks == "Sten" && _computerPicks == "Sten")
            {
                _result = MessageBox.Show($"Du valde {_playerPicks} och datorn valde {_computerPicks}. {_draw} {EndMessage()}", "Resultat", MessageBoxButton.YesNo);
                MessageBoxChoice();
            }
        }

        public void ScoreUpdatePlayer()
        {
            Resultat.Content = "Dina Poäng: " + score.PlayerScore++;
        }

        public void ScoreUpdateComputer()
        {
            DatornsResultat.Content = "Datorns Poäng: " + score.ComputerScore++;
        }

        public string EndMessage()
        {
            return "\nVill du spela igen?";
        }

        public void MessageBoxChoice()
        {

            switch (_result)
            {
                case MessageBoxResult.Yes:
                    break;
                case MessageBoxResult.No:
                    Application.Current.Shutdown();
                    break;
            }
        }
    }
}
