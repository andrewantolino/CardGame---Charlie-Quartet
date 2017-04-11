using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieQuartet
{
    public class Player
    {

        public List<Card> hand;
        public double balance;
        public double bet;

        public Player(List<Card> pHand)
        {

            //calculate the balance
            hand = pHand;
            balance = 100;
            if (balance<= 5)
            {
                Console.WriteLine("Strapped for cash? Here's a little bonus to keep you going!");
                balance = 100;
            }
            
        }

        public double placeBet(double pBet)
        {
            //calculate the bet amount 
            bet = pBet;
            //balance = balance - bet;
            return bet;

            //seting how much player can place bet  
            /* if (pBet > balance)
                Console.WriteLine("It seems you're a little short on funds for that, try something more affordable."); */

        }
        //if bet == balance - 1 thn return error " not enough money"
        //else bet is placed
        
        public void addCardToHand(Card pCard)
        { 
             // place card to hand 
            hand.Add(pCard);

          
        }



         public int CalculateHandValue()
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

       
        public void makePayment(Card pPoint)
        {
         
            // calculate point value of hand
            int total = CalculateHandValue();
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
