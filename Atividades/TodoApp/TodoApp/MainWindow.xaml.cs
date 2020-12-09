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

namespace TodoApp
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

        private void addToListBox(string item)
        {
            lbxTasks.Items.Add(item);
            txbInput.Text = "";
            btbAdd.IsEnabled = false;
        }

        private void txbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(txbInput.Text.Length == 0)
            {
                btbAdd.IsEnabled = false;
            }
            else
            {
                btbAdd.IsEnabled = true;
                if (e.Key == Key.Enter)
                {
                    addToListBox(txbInput.Text);

                }
            }
                  
        }

        private void btbAdd_Click(object sender, RoutedEventArgs e)
        {
            addToListBox(txbInput.Text);
        }

        private void btbDelete_Click(object sender, RoutedEventArgs e)
        {
            lbxTasks.Items.Remove(lbxTasks.SelectedItem);
            btbDelete.IsEnabled = false;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btbDelete.IsEnabled = true;
        }
    }
}
