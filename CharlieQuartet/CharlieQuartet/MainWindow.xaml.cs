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
            //string vGreeting = "Hello Matt!";
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Deck gameDeck = new CharlieQuartet.Deck();
            List<Card> hand = new List<Card>();
            Player andrew = new Player(hand);
            if (andrew.balance == 100.00)
            {
                andrewsLabel.Content = andrew.balance;
                testLabel.Content = "Passed!";
            }
            else
            {
                andrewsLabel.Content = "Failed";
            }
            
        }

        private void startbutton_Click(object sender, RoutedEventArgs e)
        {
            Deck testDeck = new Deck();
            testDeck.Shuffle();
            List<Card> testHand = new List<Card>();
            Player testPlayer = new CharlieQuartet.Player(testHand);
            balance.Content = testPlayer.balance;


            Card testCard1 = testDeck.DealCard();


            testPlayer.addCardToHand(testCard1);
            //card1.Content = testPlayer.hand;

            displayHand(testPlayer.hand);


        }

        private void displayHand(List<Card> pHand)
        {
            // card1.Content =  pHand[0].ToString();

            cardList.Items.Add(pHand[0]);

        }

        private void clearHandDisplay()
        {
            cardList.Items.Clear();
        }
    }
}
