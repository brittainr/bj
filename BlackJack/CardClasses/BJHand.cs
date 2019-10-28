using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;
namespace CardClasses
{
    public class BJHand : Hand
    {
        List<Card> bjhand = new List<Card>();
        public BJHand() { }

        public BJHand(Deck d, int numCards) : base(d,numCards)
        { 
        }

        public int Score
        {
            get 
            {
                int score = 0;
                for(int i =0; i < NumCards; i++)
                {
                    Card c = GetCard(i);
                    if (c.IsFaceCard())
                        score += 10;
                    else
                        score += c.Value;
                }
                if (HasAce && score <= 11)
                    score+=10;
                return score;
            }
        }

        public bool HasAce
        {
            get
            { 
                int count = 0;
                for(int i = 0; i < bjhand.Count; i++)
                {
                    Card c = bjhand[i];
                    if (c.IsAce())
                        count++;
                }
                if (count > 0)
                    return true;
                else
                    return false;
                
             }
            //get 
            //{
            //    return HasCard(i)
            //}
        }

        public bool IsBusted
        {
            
            get 
            {
                int values = 0;
               
                foreach(Card c in bjhand)
                {
                    values += c.Value;
                    
                }
                if (values >= 21)
                    return true;
                else return false;
                //if(Value>=21) //if hand value is >= 21 then it is Not busted
                //return false;
            }
        }
    }
}
