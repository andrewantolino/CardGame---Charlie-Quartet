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
        private String _suit;
        private int point;

        public Card(Suit suit, Rank rank)
        {
            _suit = suit;



        }


        public string getNumber()
        {
            return number;
        }


        public string getSuit()
        {
            return "random";
        }


       
        

        }

    }

