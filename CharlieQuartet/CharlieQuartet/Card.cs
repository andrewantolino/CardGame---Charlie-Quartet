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
        private Suit _suit;
        private int point;

        public Card(String pnumber, Suit psuit, int ppoint )
        {
            number = pnumber;
            _suit = psuit;
            point = ppoint;
        }


        public string getNumber()
        {
            return number;
        }

        public Suit getSuit()
        {
            return _suit;
        }

        public int getPoint()
        {
            return point;
        }
    }
}

