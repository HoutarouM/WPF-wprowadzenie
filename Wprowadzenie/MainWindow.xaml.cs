﻿using System;
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

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
