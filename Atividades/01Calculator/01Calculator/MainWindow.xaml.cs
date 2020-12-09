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

namespace _01Calculator
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int first = Int32.Parse(txbFirstNumber.Text);
            int second = Int32.Parse(txbSecondNumber.Text);
            lblSumResult.Content = first + " + " + second + " = " + (first + second);
            lblMinResult.Content = first + " - " + second + " = " + (first - second);
            lblDivResult.Content = first + " / " + second + " = " + (first / second);
            lblMulResult.Content = first + " * " + second + " = " + (first * second);
        }
    }
}
