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

namespace CharlieQuartet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            betbutton.IsEnabled = false;
            hitbutton.IsEnabled = false;
            stopbutton.IsEnabled = false;
            
        }

        private void displayHand(List<Card> pHand)
        {
            for (int i = 0; i < pHand.Count; i++)
            {
                cardList.Items.Add(pHand[i]);
            }

        }

        private void clearHandDisplay()
        {
            cardList.Items.Clear();
        }

        private void startbutton_Click(object sender, RoutedEventArgs e)
        {
            Deck gameDeck = new Deck();
            gameDeck.Shuffle();
            List<Card> testHand = new List<Card>();
            Player testPlayer = new CharlieQuartet.Player(testHand);
            balance.Content = testPlayer.balance;

            for (int i = 0; i < 2; i++)
            {
                testPlayer.addCardToHand(gameDeck.DealCard());
            }
            
            displayHand(testPlayer.hand);
            startbutton.IsEnabled = false;
            betbutton.IsEnabled = true;
            stopbutton.IsEnabled = true;

        }

        private void betbutton_Click(object sender, RoutedEventArgs e)
        {
            betWindow betPopUp = new betWindow();
            betPopUp.ShowDialog();
        }
    }
}
