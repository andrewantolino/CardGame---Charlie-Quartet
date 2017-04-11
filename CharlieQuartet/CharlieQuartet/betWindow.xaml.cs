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
        Player thisPlayer;
        MainWindow editForm;

        public betWindow(Player testPlayer, MainWindow mainForm)
        {
            InitializeComponent();
            thisPlayer = testPlayer;
            editForm = mainForm;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void betWindowButton_Click(object sender, RoutedEventArgs e)
        {
            double vBet = Convert.ToDouble(betWindowTextBox.Text);
            double vNewBalance;
            if (String.IsNullOrEmpty(betWindowTextBox.Text))
            {
                MessageBox.Show("Please enter a whole number");
            }
            else if (!(Double.TryParse(betWindowTextBox.Text, out vBet)))
            {
                MessageBox.Show("Please enter a number");
            }
            else if (Double.TryParse(betWindowTextBox.Text, out vBet))
            {
                vBet = Convert.ToDouble(betWindowTextBox.Text);
                thisPlayer.placeBet(vBet);
                vNewBalance = thisPlayer.balance - vBet;
                //editForm.betamountlabel.Content = vBet;
                editForm.balance.Content = vNewBalance;
                
                this.Close();
            }
        }
    }
}
