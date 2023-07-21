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

namespace _2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int X_coord{get; set;}
        private int Y_coord{get; set;}
        public MainWindow()
        {
            for (int i=0; i<300; i+=10){
                Line a = new Line();
                layoutGrid.Children.Add(a);
            }
            X_coord = 0;
            Y_coord = 0;
            InitializeComponent();
        }
        private void Set_x(object sender,  RoutedEventArgs e){
            X_coord = Convert.ToInt32(x.Text);
            X_print.Text = "X=" + x.Text;
        }
        private void Set_y(object sender,  RoutedEventArgs e){
            Y_coord = Convert.ToInt32(y.Text);
            Y_print.Text = "Y=" + y.Text;
        }
        private void Points(object sender,  RoutedEventArgs e){
            Canvas.SetLeft(poi, X_coord + 300);
            Canvas.SetTop(poi, -Y_coord + 150);
            InitializeComponent();
        }

    }
}
