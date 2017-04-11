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
    public class PlayerTests
    {
        [TestMethod()]
        public void playerTest()
        {
            double vBalance = 100;
            List<Card> testHand = new List<Card>();

            Player testPlayer = new Player(testHand);

            Assert.AreEqual(100, vBalance);
            Assert.IsInstanceOfType(testHand, typeof(List<Card>));

        }

        [TestMethod()]
        public void placeBetTest()
        {
            List<Card> testHand = new List<Card>();
            Player testPlayer = new Player(testHand);
            double vBet = testPlayer.placeBet(100);
            Assert.IsInstanceOfType(vBet, typeof(double));
        }

        [TestMethod()]
        public void addCardToHandTest()
        {
            // double vBalance = 100;
            List<Card> testHand = new List<Card>();
            Player testPlayer = new Player(testHand);
            Deck testDeck = new Deck();
            Card vFirst = testDeck._cards[0];
            testDeck.DealCard();
            testPlayer.addCardToHand(vFirst);

            Assert.IsInstanceOfType(vFirst, typeof(Card));
        }
  
        [TestMethod()]
        public void calculateHandValueTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void makePaymentTest()
        {
            Assert.Fail();
        }
    }
}
