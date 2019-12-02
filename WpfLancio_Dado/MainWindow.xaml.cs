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

namespace WpfLancio_Dado
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int numeroCasuale = random.Next(1, 6);
            int n = Convert.ToInt32(TxtBox.Text);
            if(n < 1 || n > 6)
            {
                MessageBox.Show("il numero non va bene", "errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }
          
            if(n == numeroCasuale)
            {
                TxtRst.Text = numeroCasuale +" Hai vinto";
            }
            else
            {
                TxtRst.Text = numeroCasuale + " Hai perso";
            }
        }

        private void BtnRst_Click(object sender, RoutedEventArgs e)
        {
            {
                TxtBox.Clear();
                TxtRst.Clear();

            }

        }
    }
}
