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

namespace WPFDemo
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

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                Display.Text += button.Content.ToString();
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Display.Clear();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var lastIndexInText = Display.Text.Length - 1;

            if (lastIndexInText != -1)
            {
                if (Display.Text[lastIndexInText] != '+' && Display.Text[lastIndexInText] != '-')
                {
                    Display.Text += "+";
                }
            }
        }

        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            var lastIndexInText = Display.Text.Length - 1;

            if (lastIndexInText != -1)
            {
                if (Display.Text[lastIndexInText] != '+' && Display.Text[lastIndexInText] != '-')
                {
                    Display.Text += "-";
                }
            }
        }

        private void Times_Click(object sender, RoutedEventArgs e)
        {
            var lastIndexInText = Display.Text.Length - 1;

            if (lastIndexInText != -1)
            {
                if (Display.Text[lastIndexInText] != '+' && Display.Text[lastIndexInText] != '-' && Display.Text[lastIndexInText] != '*')
                {
                    Display.Text += "*";
                }
            }
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            var lastIndexInText = Display.Text.Length - 1;

            if (lastIndexInText != -1)
            {
                if (Display.Text[lastIndexInText] != '+' && Display.Text[lastIndexInText] != '-' && Display.Text[lastIndexInText] != '*' && Display.Text[lastIndexInText] != '/')
                {
                    Display.Text += "/";
                }
            }
        }

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Result();
            }
            catch (Exception)
            {
                Display.Text = "Error! Tryck på 'CE' och skriv in vad du vill räkna ut först!";
            }

        }

        private void Result()
        {
            string operand;
            int ioperand = 0;

            if (Display.Text.Contains("+"))
            {
                ioperand = Display.Text.IndexOf("+");
            }
            else if (Display.Text.Contains("-"))
            {
                ioperand = Display.Text.IndexOf("-");
            }
            else if (Display.Text.Contains("*"))
            {
                ioperand = Display.Text.IndexOf("*");
            }
            else if (Display.Text.Contains("/"))
            {
                ioperand = Display.Text.IndexOf("/");
            }

            operand = Display.Text.Substring(ioperand, 1);
            double firstNumber = Convert.ToDouble(Display.Text.Substring(0, ioperand));
            double secondNumber = Convert.ToDouble(Display.Text.Substring(ioperand + 1, Display.Text.Length - ioperand - 1));

            if (operand == "+")
            {
                Display.Text += "=" + (firstNumber + secondNumber);
            }
            else if (operand == "-")
            {
                Display.Text += "=" + (firstNumber - secondNumber);
            }
            else if (operand == "*")
            {
                Display.Text += "=" + (firstNumber * secondNumber);
            }
            else
            {
                Display.Text += "=" + (firstNumber / secondNumber);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text.Length > 0)
            {
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
            }
        }
    }
}
