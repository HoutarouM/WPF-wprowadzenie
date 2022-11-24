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

namespace Wprowadzenie
{
    /// <summary>
    /// Interaction logic for ObliczeniaWindow.xaml
    /// </summary>
    public partial class ObliczeniaWindow : Window
    {
        public ObliczeniaWindow()
        {
            InitializeComponent();
        }

        private void Oblicz_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(a.Text, out int liczba_a))
            {
                if (int.TryParse(b.Text, out int liczba_b))
                {
                    int suma = liczba_a + liczba_b;

                    MessageBox.Show("Suma: " + suma.ToString(),
                        "Suma",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Musi byc typelniony formularz",
                        "Uwaga",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            } 
            else
            {
               MessageBox.Show("Musi byc typelniony formularz", 
                   "Uwaga",
                   MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }
        }
    }
}
