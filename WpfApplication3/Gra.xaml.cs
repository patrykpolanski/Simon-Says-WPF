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

namespace WpfApplication3
{
    /// <summary>
    /// Logika interakcji dla klasy Gra.xaml
    /// </summary>
    public partial class Gra : Window
    {
        int poziom;
        public string[] w;
        public Gra(int p)
        {
            poziom = p;
            InitializeComponent();
             w = new string[poziom];
        }

        private void btnStartKolory_Click(object sender, RoutedEventArgs e)
        {
            btnClose.IsEnabled = false;
            int j = 0;
            Random h = new Random();
            btnStartKolory.IsEnabled = false;
            for (int i = 0; i < poziom; i++)
            {
                txtI.Text = i.ToString();
                j = h.Next(1, 4);
                if (j == 1)
                {
                    w[i] = "red";
                    var uri = new Uri("pack://application:,,,/Images/red.png");
                    var bitmap = new BitmapImage(uri);
                    image.Source = bitmap;
                }
                else if (j == 2)
                {
                    w[i] = "green";
                    var uri = new Uri("pack://application:,,,/Images/green.png");
                    var bitmap = new BitmapImage(uri);
                    image.Source = bitmap;
                }
                else if (j == 3)
                {
                    w[i] = "yellow";
                    var uri = new Uri("pack://application:,,,/Images/yellow.png");
                    var bitmap = new BitmapImage(uri);
                    image.Source = bitmap;
                }
                else
                {
                    w[i] = "blue";
                    var uri = new Uri("pack://application:,,,/Images/blue.png");
                    var bitmap = new BitmapImage(uri);
                    image.Source = bitmap;
                }
                MessageBox.Show("Next");
            }
            btnClose.IsEnabled = true;
        }

        private void Zamknij_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
