using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace CardClasses
{
    public class Hand : Deck
    {
        List<Card> hand = new List<Card>();

        public Hand() { }
        public Hand(Deck d, int numCards)
        {
        }

        public int NumCards
        {
            get
            {
                return hand.Count;
            }
        }

        public void AddCard(Card c)
        {
            hand.Add(c);
        }

        public Card GetCard(int index)
        {
            return hand[index];
        }

        public int IndexOf(Card c)
        {
            int count = 0;
            for(int i = 0; i < hand.Count; i++)
            {
                if (c == hand[i])
                {
                    count = i;
                    

                }
          
                
                   
            }
            if(hand[count]==c)
            return count;
                  else
                throw new Exception("you dont have this card");

        }

        public int IndexOf(int value)
        {
            return hand[value].Value;
        }

        public int IndexOf( int value, int suit)
        {
            int counts = 0;
            for (int i = 0; i < hand.Count; i++)
            {
                if (hand[i].Suit == suit && hand[i].Value == value)
                {
                    counts = i;
                }
            }
            return counts;


            //out statements are used when methods return more than one value; 
            //those are added to the method head the definition of it.


        }

        public bool HasCard(Card c)
        {
            int count = 0;
            for(int i =0; i< hand.Count; i++)
            {
                if (hand[i] == c)
                    count++;
                 
                
                    
            }
            if (count > 0)
                return true;
            else return false;
        
               
            
            
            
        }

        public bool HasCard(int value)
        {
            int count = 0; 
            for(int i = 0; i < hand.Count; i++)
            {
                if (hand[value] == hand[i])
                {
                    count++;
                }
            }
            if (count > 0)
                return true;
            else return false;
        }

        public bool HasCard(int value, int suit)
        {
            int count = 0; 
            for(int i = 0; i > hand.Count; i++)
            {
                if (hand[i].Value == value && hand[i].Suit == suit)
                {
                    count++;
                }
            }
            if (count > 0)
                return true;
            else return false;
        }

        public Card Discard(int index)
        {
            return null;
        }

        public override string ToString()
        {
            string output = "";
            foreach (Card c in hand)
            {
                output += c.ToString();
            }
            return output;
        }
        public IEnumerator<Hand> GetEnumerator()
        {
            return (IEnumerator<Hand>)this;
        }
        public void TestingForeach()
        {
            foreach(Card c in hand)
            {
                Console.WriteLine(c);
            }
        }
    }
}
