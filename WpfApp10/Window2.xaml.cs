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
using System.Windows.Shapes;

namespace WpfApp10
{
    /// <summary>
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (first.IsChecked == true)
            {
                pics.Source = new BitmapImage(new Uri("kiciuch.jpg", UriKind.Relative));
            }
            else if (second.IsChecked == true)
            {
                pics.Source = new BitmapImage(new Uri("kotel.jpg", UriKind.Relative));
            }
            else if (third.IsChecked == true)
            {
                pics.Source = new BitmapImage(new Uri("kotelek.jpg", UriKind.Relative));
            }
            else if (fourth.IsChecked == true)
            {
                pics.Source = new BitmapImage(new Uri("kotuch.jpg", UriKind.Relative));
            }
            else if (fifth.IsChecked == true)
            {
                pics.Source = new BitmapImage(new Uri("rudycwe-cwaniaczek.jpg", UriKind.Relative));
            }
        }
    }
}
