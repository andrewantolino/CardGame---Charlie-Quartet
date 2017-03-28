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

        public Player()
        {
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
            balance = balance - pbet;
            bet = pbet;

            if (pbet > balance)
                Console.WriteLine("bet to high, make a different be.");
        }
        //if bet == balance - 1 thn return error " not enough money"
        //else bet is placed

        public void addCardToHand(Card pCard)
        {
            hand.Add(pCard);
        }
       
      

        public int calculateHandValue()
        {
            int points = 0; 

            for (int i = 0; i < hand.Count; i++)
            {
                points += hand[i].getPoint();
            }
            return points;

        }

        public void makePayment(Card ppoint)
        {
            /*

            int[] Point = new int[] { 21, 22, 23, 24, 25, 26, 27, 28, 29 };
            Dictionary<int, Double> mypoint = new Dictionary<int, Double>();
            mypoint.Add(21, 1);
            mypoint.Add(22, 1.25);
            mypoint.Add(23, 1.5);
            mypoint.Add(24, 1.75);
            mypoint.Add(25, 2);
            mypoint.Add(26, 1.75);
            mypoint.Add(27, 1.5);
            mypoint.Add(28, 1.25);
            mypoint.Add(29, 1);
            */

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
