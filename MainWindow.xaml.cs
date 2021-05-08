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

namespace Zufallsgenerator_1._0
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

        private void Button_10_Click(object sender, RoutedEventArgs e)
        {
            //code für den 1 - 10 Button
            Button_100.IsEnabled = false;
            Button_1000.IsEnabled = false;
            Button_10000.IsEnabled = false;
            Button_100000.IsEnabled = false;
            Button_1000000.IsEnabled = false;
            Butten_null.IsEnabled = true;
            Text_BesimmteZahl.Content = "Warscheinlichkeit für bestimmte Zahl: 1 / 10";
            int Zahl2;
            Zahl2 = 10;
            Random rnd = new Random();
            int Zahl = rnd.Next(1, Zahl2);
            MainText.Content = Zahl;
        }

        private void Button_100_Click(object sender, RoutedEventArgs e)
        {
            //code für den 1 - 100 Button
            Button_10.IsEnabled = false;
            Button_1000.IsEnabled = false;
            Button_10000.IsEnabled = false;
            Button_100000.IsEnabled = false;
            Button_1000000.IsEnabled = false;
            Butten_null.IsEnabled = true;
            Text_BesimmteZahl.Content = "Warscheinlichkeit für bestimmte Zahl: 1 / 100";
            int zahl2;
            zahl2 = 100;
            Random rnd = new Random();
            int Zahl = rnd.Next(1, zahl2);
            MainText.Content = Zahl;
        }

        private void Button_1000_Click(object sender, RoutedEventArgs e)
        {
            //code für 1 - 1.000 Button
            Button_10.IsEnabled = false;
            Button_100.IsEnabled = false;
            Button_10000.IsEnabled = false;
            Button_100000.IsEnabled = false;
            Button_1000000.IsEnabled = false;
            Butten_null.IsEnabled = true;
            Text_BesimmteZahl.Content = "Warscheinlichkeit für bestimmte Zahl: 1 / 1.000";
            int zahl2;
            zahl2 = 1000;
            Random rnd = new Random();
            int Zahl = rnd.Next(1, zahl2);
            MainText.Content = Zahl;
        }

        private void Button_10000_Click(object sender, RoutedEventArgs e)
        {
            //code für 1 - 10.000 Button
            Button_10.IsEnabled = false;
            Button_100.IsEnabled = false;
            Button_1000.IsEnabled = false;
            Button_100000.IsEnabled = false;
            Button_1000000.IsEnabled = false;
            Butten_null.IsEnabled = true;
            Text_BesimmteZahl.Content = "Warscheinlichkeit für bestimmte Zahl: 1 / 10.000";
            int zahl2;
            zahl2 = 10000;
            Random rnd = new Random();
            int Zahl = rnd.Next(1, zahl2);
            MainText.Content = Zahl;
        }

        private void Button_100000_Click(object sender, RoutedEventArgs e)
        {
            //code für den 1 - 100.000 Button
            Button_10.IsEnabled = false;
            Button_100.IsEnabled = false;
            Button_1000.IsEnabled = false;
            Button_10000.IsEnabled = false;
            Button_1000000.IsEnabled = false;
            Butten_null.IsEnabled = true;
            Text_BesimmteZahl.Content = "Warscheinlichkeit für bestimmte Zahl: 1 / 100.000";
            int zahl2;
            zahl2 = 100000;
            Random rnd = new Random();
            int Zahl = rnd.Next(1, zahl2);
            MainText.Content = Zahl;
        }

        private void Button_1000000_Click(object sender, RoutedEventArgs e)
        {
            //code für den 1 - 1.000.000 Button
            Button_10.IsEnabled = false;
            Button_100.IsEnabled = false;
            Button_1000.IsEnabled = false;
            Button_10000.IsEnabled = false;
            Button_100000.IsEnabled = false;
            Butten_null.IsEnabled = true;
            Text_BesimmteZahl.Content = "Warscheinlichkeit für bestimmte Zahl: 1 / 1.000.000";
            int zahl2;
            zahl2 = 1000000;
            Random rnd = new Random();
            int Zahl = rnd.Next(1, zahl2);
            MainText.Content = Zahl;
        }

        private void Butten_null_Click(object sender, RoutedEventArgs e)
        {
            //code für den clear Button
            Button_10.IsEnabled = true;
            Button_100.IsEnabled = true;
            Button_1000.IsEnabled = true;
            Button_10000.IsEnabled = true;
            Button_100000.IsEnabled = true;
            Button_1000000.IsEnabled = true;
            Butten_null.IsEnabled = false;
            MainText.Content = "Generierte Zahl";
            Text_BesimmteZahl.Content = "";
        }

        private void Button_block_Click(object sender, RoutedEventArgs e)
        {
            //code für den block Button
            Button_10.IsEnabled = false;
            Button_100.IsEnabled = false;
            Button_1000.IsEnabled = false;
            Button_10000.IsEnabled = false;
            Button_100000.IsEnabled = false;
            Button_1000000.IsEnabled = false;
            Butten_null.IsEnabled = false;
            Button_block.IsEnabled = false;
            Button_unlock.IsEnabled = true;
        }

        private void Button_unlock_Click(object sender, RoutedEventArgs e)
        {
            //code für den unlock Button
            Button_10.IsEnabled = true;
            Button_100.IsEnabled = true;
            Button_1000.IsEnabled = true;
            Button_10000.IsEnabled = true;
            Button_100000.IsEnabled = true;
            Button_1000000.IsEnabled = true;
            Butten_null.IsEnabled = false;
            Button_block.IsEnabled = true;
            Button_unlock.IsEnabled = false;
            Text_BesimmteZahl.Content = "";
            MainText.Content = "Generierte Zahl";
        }
    }
}
