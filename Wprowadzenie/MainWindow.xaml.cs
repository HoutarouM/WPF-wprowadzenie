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

namespace Wprowadzenie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // divs:
        //  - stack pane
        //  - dockpanel:
        //      - dockpanel.dock="strona"
        //  - WrapPanel
        //  - UniformGrid
        //  - Grid:
        //      - ColumnDefinitions
        //      - RowDefinitions
        //      - Grid.Row
        //      - Grid.Column
        //  - Canvas:
        //      - Rectangle
        
        //  label sformatowany
        //  textblock nie
        //  tekst tylko we srodku albo w text(content)
        // formatowac tekst mozna tylko w text form, w lable error

        public MainWindow()
        {
            InitializeComponent();

            textBlock.Text = "jakis text z c#";
        }

        private void Rename_Click(object sender, RoutedEventArgs e)
        {
            string text = textBox.Text.ToString();
            textBlock2.Text = text;
        }
    }
}
