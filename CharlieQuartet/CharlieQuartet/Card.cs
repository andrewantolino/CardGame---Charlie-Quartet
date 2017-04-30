using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieQuartet
{
    public class Card
    {
        private string number;
        private string _suit;
        public int point;

        public Card(String pNumber, string pSuit, int pPoint)
        {
            _suit = pSuit;
            number = pNumber;
            point = pPoint;
        }


        public string getNumber()
        {
            return number;
        } 

        public int getPoint()
        {
            return point;
        }

        public string getSuit()
        {
            return _suit;
        }

        public override string ToString()
        {
            // return base.ToString();
            return number + " of " + _suit;
       }

    }
}
    


