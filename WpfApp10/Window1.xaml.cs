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
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp10
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (wyborCombo.Text == "jeden")
            {
                pics.Source = new BitmapImage(new Uri("kiciuch.jpg", UriKind.Relative));
            }
            else if (wyborCombo.Text == "dwa")
            {
                pics.Source = new BitmapImage(new Uri("kotel.jpg", UriKind.Relative));
            }
            else if (wyborCombo.Text == "trzy")
            {
                pics.Source = new BitmapImage(new Uri("kotelek.jpg", UriKind.Relative));
            }
            else if (wyborCombo.Text == "cztery")
            {
                pics.Source = new BitmapImage(new Uri("kotuch.jpg", UriKind.Relative));
            }
            else if (wyborCombo.Text == "pięć")
            {
                pics.Source = new BitmapImage(new Uri("rudycwe-cwaniaczek.jpg", UriKind.Relative));
            }
        }
    }
}
