using System;
using System.Collections.Generic;
using System.IO;
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

namespace ReadAndWrite
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

        string _path = @"C:\temp\MyText.txt";

        /// <summary>
        /// Metod för att hantera klick på SaveButton.
        /// Läser filen på platsen: C:\temp\MyText.txt och ersätter texten i MainTextArea med innehållet i filen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainTextArea.Text == null || MainTextArea.Text == String.Empty)
            {
                return;
            }

            //Alt. 1
            //StreamWriter writer1 = new StreamWriter(_path);
            //writer.Dispose();

            var listOfWords = MainTextArea.Text.Split();

            //Alt. 2
            using (var writer = new StreamWriter(_path))
            {
                foreach (var word in listOfWords)
                {
                    writer.WriteLine(word);
                }
            }

            //Alt. 3
            //using var writer2 = new StreamWriter(_path);
        }
        /// <summary>
        /// Metod för att hantera klick på OpenButton.
        /// Läser filen på platsen: C:\temp\MyText.txt och ersätter texten i MainTextArea med innehållet i filen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            //Den här kommer innehålla texten som skriv i MainTextArea
            string fileContent = "";

            //Använder ett StreamReader objekt för att läsa in textfilen i platsen och lägger till ett mellanslag i varje rad i fileContent
            using (var reader = new StreamReader(_path))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    fileContent += line + " ";
                }

                fileContent = fileContent.Trim();
            }

            //Byter ut texten i MainTextArea med texten i fileContent
            MainTextArea.Text = fileContent;
        }
    }
}
