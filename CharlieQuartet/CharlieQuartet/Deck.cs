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
                    String[] mySuits = new String[] { "Spades", "Hearts", "Clubs", "Diamonds" };
                    String[] myRank = new String[] { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" ,"Jack", "Queen", "King" };

                    Dictionary<string, int> myPoints = new Dictionary<string, int>();
                    myPoints.Add("Ace", 0);
                    myPoints.Add("Two", 2);
                    myPoints.Add("Three", 3);
                    myPoints.Add("Four", 4);
                    myPoints.Add("Five", 5);                      
                    myPoints.Add("Six", 6);
                    myPoints.Add("Seven", 7);
                    myPoints.Add("Eight", 8);
                    myPoints.Add("Nine", 9);
                    myPoints.Add("Ten", 10);
                    myPoints.Add("Jack", 10);                                                        
                    myPoints.Add("Queen", 10);
                    myPoints.Add("King", 10);

                    _cards = new List<Card>();

                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 13; j++)
                        {
                            _cards.Add(new Card(myRank[j], mySuits[i], myPoints[myRank[j]]));
                        }
                    }


                    /*
            abstract class player
            {
            abstract private Card cardToHand();
            } 

            if()
            {

            }
            */

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


        public Card DealCard ()
        {
            Card dealtCard = _cards[0];
            _cards.RemoveAt(0);
            return dealtCard;
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


        // this method is to enable testing only - please comment out when delivering to production

        public Card getCardByIndex(int pIndex)
        {
            return _cards[pIndex];
        }


    }

    

}
