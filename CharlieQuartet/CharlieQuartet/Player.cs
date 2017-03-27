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
        decimal balance;
        decimal bet = 0; 

        public Player()
        {
            hand = new List<Card>();
            balance = 100;

        }

        public void addCardToHand(Card pCard)
        {
            hand.Add(pCard);
        }
       
        public void placeBet(decimal pbet)
        {
            balance = balance - pbet;
            bet = pbet;
        }

        public int calculateHandValue()
        {
            int points = 0; 

            for (int i = 0; i < hand.Count; i++)
            {
                points += hand[i].getPoint();
            }
        }

    }
}
