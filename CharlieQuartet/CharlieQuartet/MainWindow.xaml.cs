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
        List<Card> testHand = new List<Card>();
        Card POINT;
        Deck testDeck;


        public MainWindow()
        {
            InitializeComponent();
            testPlayer = new Player(testHand); 
            betbutton.IsEnabled = false;
            hitbutton.IsEnabled = false;
            stopbutton.IsEnabled = false;
        }

        private void displayHand(List<Card> pHand)
        {
            for (int i = 0; i < pHand.Count; i++)
            {
                cardList.Items.Add(pHand[i].ToString());
            }

        }

        private void clearHandDisplay()
        {
            cardList.Items.Clear();
        }

        private void clearCardPoints()
        {
            cardpoints.Content = "";
        }

        private void startbutton_Click(object sender, RoutedEventArgs e)
        {
            testDeck = new Deck();
            testDeck.Shuffle();
            betamount.Content = "";
            balance.Content = "$" + testPlayer.balance;
            clearHandDisplay();
            clearCardPoints();
            testPlayer.hand = new List<Card>();
            testHand = testPlayer.hand;
           
            for (int i = 0; i < 2; i++)
            {
                testPlayer.addCardToHand(testDeck.DealCard());

                if (testPlayer.hand[i].point == 1)
                {
                        MainWindow mainForm = new MainWindow();
                        aceWindow acePopUp = new aceWindow(testPlayer, mainForm);
                        acePopUp.ShowDialog();
                        //cardpoints.Content = testPlayer.hand[i].point;
                }

            }

            displayHand(testPlayer.hand);
            cardpoints.Content = testPlayer.CalculateHandValue();
            startbutton.IsEnabled = false;
            betbutton.IsEnabled = true;
            stopbutton.IsEnabled = true;
            
        }

        private void betbutton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainForm = new MainWindow();
            betWindow betPopUp = new betWindow(testPlayer, mainForm);
            betPopUp.ShowDialog();
            balance.Content = "$" + testPlayer.balance;
            betamount.Content = "$" + testPlayer.bet;
            betbutton.IsEnabled = false;
            hitbutton.IsEnabled = true;
            stopbutton.IsEnabled = true;
            
        }

        private void hitbutton_Click(object sender, RoutedEventArgs e)
        {
            //each time click on hit button randam card is thrown
            testPlayer.addCardToHand(testDeck.DealCard());
            //POINT.getSuit();
            clearHandDisplay();
            displayHand(testPlayer.hand);

            if (testPlayer.hand[testPlayer.hand.Count - 1].point == 1)
            {
                MainWindow mainForm = new MainWindow();
                aceWindow acePopUp = new aceWindow(testPlayer, mainForm);
                acePopUp.ShowDialog();
                //cardpoints.Content = testPlayer.hand[i].point;
            }
            
            cardpoints.Content = testPlayer.CalculateHandValue();
           
            if(Convert.ToInt32(cardpoints.Content)>= 30)
            {
                MessageBox.Show("you have lost");
                betbutton.IsEnabled = false;
                hitbutton.IsEnabled = false;
                stopbutton.IsEnabled = false;
                startbutton.IsEnabled = true;
                cardpoints.Content = 0;
            }
        }

        private void stopbutton_Click(object sender, RoutedEventArgs e)
        {
            int vPoints = testPlayer.CalculateHandValue();
            MessageBox.Show("You have earned $" + testPlayer.makePayment(vPoints));
            startbutton.IsEnabled = true;
            hitbutton.IsEnabled = false;
            stopbutton.IsEnabled = false;
            betbutton.IsEnabled = false;
            betamount.Content = "";
            balance.Content = "$" + testPlayer.balance;
            //this.Close();
        }


        /*public int getAceByNumber(int pNumber)
        {
            // If the index value is 0 and/or the card number = Ace, that obviously means you've drawn an Ace card. When that happens, a popup will appear that will ask the player to decide the value for the card, the choice is either 1 or 11.
            return 
        }*/

    }
}
