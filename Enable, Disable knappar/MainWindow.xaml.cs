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

namespace Enable_Disable_Knappar
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

        private void Enable_Click(object sender, RoutedEventArgs e)
        {
            Enable.IsEnabled = false;
            Disable.IsEnabled = true;
        }

        private void Disable_Click(object sender, RoutedEventArgs e)
        {
            Enable.IsEnabled = true;
            Disable.IsEnabled = false;
        }
    }
}
