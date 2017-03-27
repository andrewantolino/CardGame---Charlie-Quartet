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
        public string _suit;
        public int point;

        public Card(String pnumber, string psuit, int ppoint)
        {
            _suit = psuit;
            number = pnumber;
            point = ppoint;
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

    }
}
    


