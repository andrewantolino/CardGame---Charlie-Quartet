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
        double vBet;


        public betWindow(Player testPlayer, MainWindow mainForm)
        {
            InitializeComponent();
            thisPlayer = testPlayer;
            editForm = mainForm;
        }

        
        private void betWindowButton_Click(object sender, RoutedEventArgs e)
        {

            //double vNewBalance;

            if (String.IsNullOrEmpty(betWindowTextBox.Text))
            {
                MessageBox.Show("Please enter a whole number");
            }
            else if (!(Double.TryParse(betWindowTextBox.Text, out vBet)))
            {
                MessageBox.Show("Please enter a whole number");
            }
            else if (Double.TryParse(betWindowTextBox.Text, out vBet))
            {
                double vConvBet = Convert.ToDouble(betWindowTextBox.Text);
                thisPlayer.placeBet(vConvBet);
                thisPlayer.balance -= thisPlayer.bet;
                editForm.balance.Content = thisPlayer.balance;
                editForm.betamount.Content = thisPlayer.bet;
                editForm.betbutton.IsEnabled = false;
                this.Close();

            }
        }
    }
}
