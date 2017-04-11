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

namespace CharlieQuartet
{
    /// <summary>
    /// Interaction logic for betWindow.xaml
    /// </summary>
    public partial class betWindow : Window
    {
        public betWindow()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void betWindowButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(betWindowTextBox.Text))
            {
                MessageBox.Show("Please enter a whole number");
            }
            /*else if (betWindowTextBox.Text is typeof string))
            {

            }
            */
        }
    }
}
