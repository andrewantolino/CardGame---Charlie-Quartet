using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieQuartet
{
    public class Deck
    {

        private List<Card> _cards;

        public Deck(string pnumber, string psuit, int ppoint)
        {
            Suit[] mySuits = new Suit[] {Suit.Spades,Suit.Hearts,Suit.Clubs,Suit.Diamonds };
            Rank[] myRank = new Rank[] { Rank.Ace, Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six, Rank.Seven, Rank.Eight, Rank.Nine, Rank.Jack, Rank.Queen, Rank.king };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    cards.Add(new Card(mySuits[i], myRank[j]));
                    
                }
            }
            _cards = new List<Card>();
            
           
            Console.WriteLine();
        }

        public void Shuffle()
        {
            Random rand = new Random();
            int r = rand.Next(0, 52);

            Card[] cards = new Card[] { };
          
            for (int i = 0; i < 52; i++)
            {
                if (Equals(cards[i], _cards[r] ))
                {

                }
               //ccards[i] = 
            }
        }

    }
}
