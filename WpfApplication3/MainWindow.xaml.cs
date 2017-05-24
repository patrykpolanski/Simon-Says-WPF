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

namespace WpfApplication3
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int poziom = 0;
        string[] wyniki;
        string[] w;
        int i;
        public MainWindow()
        {
            InitializeComponent();
            txtWynik.IsEnabled = false;
            btnSprawdz.IsEnabled = false;
        }
        public void Restart()
        {
            i = 0;
            poziom = 0;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            i = 0;
            btnSprawdz.IsEnabled = false;
            btnStart.IsEnabled = false;
            wyniki = new string[poziom + 1];
            txtWynik.Text = "Poziom: " + poziom.ToString();
            Gra game = new Gra(poziom + 1);
            game.Show();
            poziom++;
            btnSprawdz.IsEnabled = true;
            w = game.w;
            txtTablica.Text = "";
        }

        private void btnRed_Click(object sender, RoutedEventArgs e)
        {
            wyniki[i] = "red";
            txtTablica.Text += "red ";
            i++;
        }

        private void btnBlue_Click(object sender, RoutedEventArgs e)
        {
            wyniki[i] = "blue";
            txtTablica.Text += "blue ";
            i++;
        }

        private void btnGreen_Click(object sender, RoutedEventArgs e)
        {
            wyniki[i] = "green";
            txtTablica.Text += "green ";
            i++;
        }

        private void btnYellow_Click(object sender, RoutedEventArgs e)
        {
            wyniki[i] = "yellow";
            txtTablica.Text += "yellow ";
            i++;
        }

        private void btnSprawdz_Click(object sender, RoutedEventArgs e)
        {
            bool wynik = false;
            for (i = 0; i < w.Length; i++)
            {
                if (wyniki[i] == w[i])
                {
                    wynik = true;
                    continue;
                }
                else
                {
                    MessageBox.Show("Przegrałeś na poziomie: " + poziom.ToString() + " Wpisałeś: " + wyniki[i] + " ,a powinieneś: " + w[i] + " :(\nNastąpi restart gry od początku");
                    wynik = false;
                    break;
                }
            }
            if (wynik == true) MessageBox.Show("Przeszedłeś poziom: " + poziom.ToString() + " :)");
            if (wynik == false) Restart();
            btnStart.IsEnabled = true;
            btnSprawdz.IsEnabled = false;
        }
    }
}
