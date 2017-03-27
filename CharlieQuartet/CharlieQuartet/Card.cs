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
        public Suit _suit;
        public int point;

        public Card(String pnumber, Suit psuit, int ppoint )
        {
            _suit = suit;
        }


        public string getNumber()
        {
            return number;
        }

        public void setNumber(string aNumber)
        {
            number = aNumber;
        }

        public int getPoint()
        {
            return point;
        }
    }
}

