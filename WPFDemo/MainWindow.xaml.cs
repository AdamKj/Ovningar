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
                Display.Text += button.Content;
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
            Display.Text += "*";
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "/";
        }

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            var separators = new[] { '+', '-', '*', '/', '=' };
            var numbers = Display.Text.Split(separators);

            var result = 0;

            foreach (var number in numbers)
            {
                var num = int.Parse(number);
                
                if (Display.Text.Contains('+'))
                {
                    result += num;
                }
                else if (Display.Text.Contains('-'))
                {
                    result -= num;
                }
            }

            var output = "=" + result;

            Display.Text += output;
        }
    }
}
