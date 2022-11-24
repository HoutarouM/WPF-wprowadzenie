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
    /// Interaction logic for WindowKwadrat.xaml
    /// </summary>
    public partial class WindowKwadrat : Window
    {
        public WindowKwadrat()
        {
            InitializeComponent();
        }

        private void Oblicz_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(boktextbox.Text, out double bok) && bok > 0)
            {
                komunikat.Text = String.Empty;

                double pole = bok * bok;
                poletextbox.Text = pole.ToString();

                double obwod = 4 * bok;
                obwodtextbox.Text = obwod.ToString();
            } 
            else
            {
                komunikat.Text = "Wpisz dodatnia liczbe";    
            }
        }
    }
}
