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
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Obraz> pictures = new List<Obraz>();
        int temp = 0;

        public MainWindow()
        {
            InitializeComponent();
            pictures.Add(new Obraz("kiciuch.jpg"));
            pictures.Add(new Obraz("kotel.jpg"));
            pictures.Add(new Obraz("kotelek.jpg"));
            pictures.Add(new Obraz("kotuch.jpg"));
            pictures.Add(new Obraz("rudycwe-cwaniaczek.jpg"));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            temp--;
            if(temp < 0)
            {
                temp = pictures.Count - 1;
            }
            wyswietlObraz(temp);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            temp++;
            if(temp == pictures.Count)
            {
                temp = 0;
            }
            wyswietlObraz(temp);
        }
        private void wyswietlObraz(int i)
        {
            picImage.Source = new BitmapImage(new Uri(pictures[i].UrlObrazka, UriKind.Relative));
            polubBoxik.Text = pictures[i].licznikPolubien.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            pictures[temp].licznikPolubien++;
            wyswietlObraz(temp);
        }
    }
}
