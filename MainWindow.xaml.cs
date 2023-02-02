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

namespace WpfApp3
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

        private void SzinKeveres()
        {
            rctTeglalap.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(sliPiros.Value), Convert.ToByte(sliZold.Value), Convert.ToByte(sliKek.Value)));
        }


        private void sliPiros_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbPiros.Content = Convert.ToString(Convert.ToByte(sliPiros.Value));
            SzinKeveres();
        }

        private void sliZold_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbZold.Content = Convert.ToString(Convert.ToByte(sliZold.Value));
            SzinKeveres();
        }

        private void sliKek_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbKek.Content = Convert.ToString(Convert.ToByte(sliKek.Value));
            SzinKeveres();
        }


        


        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            
            String szin = Math.Round(sliPiros.Value) + ";" + Math.Round(sliZold.Value) + ";" + Math.Round(sliKek.Value);

            if (lbSzinek.Items.Contains(szin))
            {
                MessageBox.Show("Ilyan szín már van a listában");
            }

            else
            {
                lbSzinek.Items.Add(szin);
            }
            
            


        }

        private void btnUrit_Click(object sender, RoutedEventArgs e)
        {
            lbSzinek.Items.Clear();
        }
        
        private void btnTorol_Click(object sender, RoutedEventArgs e)
        {
            if (lbSzinek.SelectedItem != null)
            {
                lbSzinek.Items.Remove(lbSzinek.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nincs szín kiválasztva");
            }
            
        }

        private void DoubleClick(object sender, MouseButtonEventArgs e)
        {
            string[] tagok = lbSzinek.SelectedItem.ToString().Split(';');

            rctTeglalap.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(tagok[0]), Convert.ToByte(tagok[1]), Convert.ToByte(tagok[2])));
        }
    }
}
