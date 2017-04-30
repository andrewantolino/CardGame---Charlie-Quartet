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
        public double bet;
        public double balance;
        

        public Player(List<Card> pHand)
        {

            //calculate the balance
            hand = pHand;
            bet = 0;
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
            balance -= bet;
            return bet;

        }
        //if bet == balance - 1 thn return error " not enough money"
        //else bet is placed
        
        public void addCardToHand(Card pCard)
        {
            hand.Add(pCard);
        }



         public int CalculateHandValue()
        {
            // if ace is 1 or 11
            // calculating all the points

            int points = 0;

            for (int i = 0; i < hand.Count; i++)
            {
                if (hand[i].getPoint() == 1)
                {
                    points += hand[i].getPoint();
                }
                else
                {
                    points += hand[i].getPoint();
                }
           
            }
            return points;
        } 

        public double makePayment(int pPoint)
        {
         
            // calculate point value of hand
            int total = CalculateHandValue();
            // calculate payout amount based on points and bet

            double multiplyer;

            switch (total)
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
            return payout;
            // optional - reset game

        }
    } 
}
