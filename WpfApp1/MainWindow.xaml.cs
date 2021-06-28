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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button b)
            {
                Random r = new Random();
                b.Background = new SolidColorBrush(Color.FromRgb((byte) r.Next(1, 255),
              (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
                MessageBox.Show(b.Content.ToString());
            }
        }

        private void Button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button b)
            {
                Title = b.Content.ToString();
                b.Visibility = Visibility.Collapsed;
            }
        }
    }
}
