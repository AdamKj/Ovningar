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

namespace DataBindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Car car = new Car("Volvo V60", 499000, "Black");
        public MainWindow()
        {
            InitializeComponent();
            DataContext = car;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            car.HalfPrice();

            BindingExpression binding = PriceText.GetBindingExpression(TextBlock.TextProperty);
            binding.UpdateTarget();
            binding = PriceTextBox.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateTarget();
            //var message = $"{car.Model}\n{car.Price}\n{car.Color}";
            //MessageBox.Show(message);
        }
    }
}
