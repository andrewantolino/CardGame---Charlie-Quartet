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

        
            public Deck()
                {
                    Suit[] mySuits = new Suit[] { Suit.Spades, Suit.Hearts, Suit.Clubs, Suit.Diamonds };
                    Rank[] myRank = new Rank[] { Rank.Ace, Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six, Rank.Seven, Rank.Eight, Rank.Nine, Rank.Jack, Rank.Queen, Rank.king };
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 12; j++)
                        {
                            _cards.Add(new Card(mySuits[i], myRank[j]));

                        }
                    }
                    _cards = new List<Card>();


                    Console.WriteLine();
        }

        static Random r = new Random();

        public void Shuffle()
        {
            for (int n = _cards.Count - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                Card temp = _cards[n];
                _cards[n] = _cards[k];
                _cards[k] = temp;
            }
        }


    
        
            
        /*  public void Shuffle()
          {
               Random rand = new Random();
               int r = rand.Next(0, 51);

               Card[] cards = new Card[] { };


               for (int i = 0; i < 52; i++)
               {
                   if (Equals(cards[i], _cards[r] ))
                   {

                     int temp = _cards[r] ;
                       _cards[r] = card[i]
                   }
          //ccards[i] = 
      }
  }*/



    }

    

}
