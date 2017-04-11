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
        Player testPlayer;
        List<Card> testHand;
        MainWindow thisWindow;

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
            testHand = new List<Card>();
            testPlayer = new CharlieQuartet.Player(testHand);
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
            MessageBox.Show(testPlayer.bet.ToString());
            betWindow betPopUp = new betWindow(testPlayer, thisWindow);
            betPopUp.ShowDialog();

            MessageBox.Show(testPlayer.bet.ToString());
        }

        private void stopbutton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /*public int getAceByNumber(int pNumber)
        {
            // If the index value is 0 and/or the card number = Ace, that obviously means you've drawn an Ace card. When that happens, a popup will appear that will ask the player to decide the value for the card, the choice is either 1 or 11.
            return 
        }*/
    }
}
