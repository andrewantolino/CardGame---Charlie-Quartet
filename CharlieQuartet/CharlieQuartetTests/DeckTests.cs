using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharlieQuartet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieQuartet.Tests
{
    [TestClass()]
    public class DeckTests
    {
        [TestMethod()]
        public void DeckTest()
        {
            // if we have store all the suits and rank 
            Deck shitdeck = new Deck();
            Deck firstPoint = points.getpointsByIndex();
            
            Card firstcard = shitdeck.getCardByIndex(0);
            Card tenthcard = shitdeck.getCardByIndex(9);
            Card twentiethcard = shitdeck.getCardByIndex(19);


            Assert.AreEqual(firstcard, shitdeck.getCardByIndex(0));
            Assert.AreEqual(tenthcard, shitdeck.getCardByIndex(9));
            Assert.AreEqual(twentiethcard, shitdeck.getCardByIndex(19));

            // if we are returning point value


            // if we are getting points depending on suit an rank

        }

        [TestMethod()]
        public void ShuffleTest()
        {
            Deck shitdeck = new Deck();
            Card firstcard = shitdeck.getCardByIndex(0);
            Card tenthcard = shitdeck.getCardByIndex(9);
            Card twentiethcard = shitdeck.getCardByIndex(19);



            shitdeck.Shuffle();


            Assert.AreNotSame(firstcard, shitdeck.getCardByIndex(0));

            Assert.AreNotSame(tenthcard, shitdeck.getCardByIndex(9));

            Assert.AreNotSame(twentiethcard, shitdeck.getCardByIndex(19));


        }

        [TestMethod()]
        public void DealCardTest()
        {
            Deck shitdeck = new Deck();

            Card firstCard = shitdeck.getCardByIndex(0);

            Card tenthCard = shitdeck.getCardByIndex(9);

            Card twentiethCard = shitdeck.getCardByIndex(19);

            Card dealtCard = shitdeck.DealCard();

            Assert.AreSame(firstCard, dealtCard);

            Assert.AreSame(tenthCard, dealtCard);

            Assert.AreSame(twentiethCard, dealtCard);

            Assert.AreNotSame(firstCard, shitdeck.getCardByIndex(0));

            Assert.AreNotSame(tenthCard, shitdeck.getCardByIndex(9));

            Assert.AreNotSame(twentiethCard, shitdeck.getCardByIndex(19));




        }

       
    }
}