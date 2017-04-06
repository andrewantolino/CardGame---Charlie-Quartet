using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieQuartet
{
    public class Player
    {

        private List<Card> hand;
        double balance;
        double bet = 0;

        public Player(List<Card> pHand, )
        {
            //calculate the balance
            hand = new List<Card>();
            balance = 100;
            if (balance<= 5)
            {
                Console.WriteLine("not enough money? heres some so you can keep playing");
                balance = 100;
            }
            
        }

        public void placeBet(double pbet)
        {
            //calculate the bet amount 
            balance = balance - pbet;
            bet = pbet;

            //seting how much player can place bet  
            if (pbet > balance)
                Console.WriteLine("bet to high, make a different be.");
        }
        //if bet == balance - 1 thn return error " not enough money"
        //else bet is placed
        
        public void addCardToHand(Card pCard)
        { 
             // place card to hand 
            hand.Add(pCard);

          
        }
       
     

        public int calculateHandValue()
        {


              // if ace is 1 or 11
           

             // calculating all the points
            int points = 0;

            for (int i = 0; i < hand.Count; i++)
            {
                points += hand[i].getPoint();
                if (hand[i].getNumber() == "Ace")
                {
                    Console.WriteLine("what do you want Ace to be");

                    // popup saying if you want ace to be 1 or 11 

                    // add either 1 or 11 to points


                }
                else
                {
                    points += hand[i].getPoint();

                }
            }
            return points;

        }

       
        public void makePayment(Card ppoint)
        {
         
     

            // calculate point value of hand
            int total = calculateHandValue();
            // calculate payout amount based on points and bet

            double multiplyer;

            switch( total)
            {
                case 21:
                    multiplyer = 1;
                    break;
                case 22:
                    multiplyer = 1.25;
                    break;
                case 23:
                    multiplyer = 1.5;
                    break;
                case 24:
                    multiplyer = 1.75;
                    break;
                case 25:
                    multiplyer = 2;
                    break;
                case 26:
                    multiplyer = 1.75;
                    break;
                case 27:
                    multiplyer = 1.5;
                    break;
                case 28:
                    multiplyer = 1.25;
                    break;
                case 29:
                    multiplyer = 1;
                    break;
                default:
                    multiplyer = 0;
                    break;
            }
            // make payment
            double  payout =  multiplyer * bet;
            balance += payout;
            bet = 0; 
            // optional - reset game

        }
    }
}
