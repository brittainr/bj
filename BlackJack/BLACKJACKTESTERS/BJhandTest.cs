using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CardClasses;

namespace BLACKJACKTESTERS
{
    [TestFixture]
    public class BJhandTest
    {
        Card a;
        Card b;
        Card c;
        Card f;
        Card g;
        Deck d;
        BJHand bj;
        Hand h;





        [SetUp]
        public void SetUpAllTests()
        {
            a = new Card(1,1);
            b = new Card(10,1);
            c = new Card(2,2);
            f = new Card(10, 2);
            g = new Card(10, 3);
            d = new Deck();
            bj = new BJHand();
            h = new Hand();


        }
        [Test]
        public void TestingHasAce()
        {
            bj.AddCard(a);
            Console.WriteLine(bj);
            Assert.IsTrue(bj.HasAce);
               
        }
        [Test]
        public void TestingIsBusted()
        {
            bj.AddCard(b);
            bj.AddCard(f);
            bj.AddCard(g);
        }

        [Test]
        public void TestingScore()
        {
            bj.AddCard(b);
            Console.WriteLine(bj.Score.ToString());
            Assert.IsTrue(bj.Score == 10);
            

        }
        [Test]
        public void TestingNumCards()
        {
            h.AddCard(c);
            Assert.True(h.NumCards == 1);
           
            
        }
        
        
        [Test]
        public void TestingAddC()
        {
            Assert.AreEqual(h.NumCards, 0);
            h.AddCard(c);
            Assert.IsTrue(h.NumCards == 1);
        }
        [Test]
        public void TestingGetCard()
        {
            h.AddCard(a);
            h.AddCard(b);
            h.AddCard(c);
            h.AddCard(f);
            h.AddCard(g);
            Assert.IsTrue(a == h.GetCard(0));
        }
       [Test]
       public void TestingIndexOfC()
        {
            h.AddCard(a);
            h.AddCard(b);
            h.AddCard(c);
            h.AddCard(f);
            h.AddCard(g);
            Assert.IsTrue(h.IndexOf(a) == 0);
            Assert.IsTrue(h.IndexOf(b) == 1);
        }

        [Test]
        public void TestingIndexOfIntValue()
        {
            h.AddCard(a);
            h.AddCard(b);
            h.AddCard(c);
            h.AddCard(f);
            h.AddCard(g);
            Assert.IsTrue(h.IndexOf(0) == a.Value);
            Assert.IsTrue(h.IndexOf(1) == b.Value);

        }
        [Test]
        public void TestingIndexOfIntValueSuit()
        {
            h.AddCard(a);
            h.AddCard(b);
            h.AddCard(c);
            h.AddCard(f);
            h.AddCard(g);
            Assert.IsTrue(h.IndexOf(1, 1) == 0);
           Assert.IsTrue(h.IndexOf(2,2) == 2);
        }
        [Test]
        public void TestingHasCardC()
        {
            h.AddCard(a);
            Assert.IsTrue(h.HasCard(a));
        }
        [Test]
        public void TestingHasCardValue()
        {
            h.AddCard(a);
            h.AddCard(b);
            h.AddCard(c);
            h.AddCard(f);
            h.AddCard(g);
            Assert.IsTrue(h.IndexOf(b) == 1);
            Assert.IsTrue(h.HasCard(1));
            
        }
        
        [Test]
        public void TestingDiscard()
        {
            h.AddCard(a);
            h.AddCard(b);
            h.AddCard(c);
            h.AddCard(f);
            h.AddCard(g);
            h.Discard(0);
            Assert.IsFalse(h.HasCard(0));
            

        }
        [Test]
        public void TesitngForeach()
        {
            h.AddCard(c);
            h.AddCard(a);
            foreach (Card c in h)
            {

            }
        }

    }
    //use using statements to include n unit tests.





}
