using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CardClasses;

namespace BLACKJACKTESTS
{
    [TestFixture]
    public class BJhandTest
    {
        Card a;
        Card b;
        Card c;
        Deck d;
        BJHand bj;





        [SetUp]
        public void SetUpAllTests()
        {
            a = new Card(10, 1);
            b = new Card();
            c = new Card();
            d = new Deck();
            bj = new BJHand();


        }
        [Test]
        private void TestingSCore()
        {
            Assert.True(d.NumCards == 4);
        }



    }
    //use using statements to include n unit tests.





}
