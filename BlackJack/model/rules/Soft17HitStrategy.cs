using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class Soft17HitStrategy : IHitStrategy
    {
        private const int g_hitLimit = 17;
        private bool once = false;
        
        /*Detta är vår tolkning på problembeskrvningen utav soft17 
         * (Ändring kan ske vid kontakt med "kunden"). */
        public bool DoHit(model.Player a_dealer)
        {
            int score = a_dealer.CalcScore();

            if (score == 17)
            {
                foreach (Card c in a_dealer.GetHand())
                {
                    if (!once)
                    {
                        if (c.GetValue() == Card.Value.Ace)
                        {

                            score -= 10;
                            once = true;

                        }
                    }
                }
            }

            return score < g_hitLimit;
        }
    }
}




// OLD SOLUTIONS...


            //int score = a_dealer.CalcScore();
            //            bool once = false;
            //            int accValue = 0;
            //            foreach(Card c in a_dealer.GetHand())
            //            {
            //                if (c.GetValue() == Card.Value.Ace && (accValue + 11 == 17 || accValue + 1 == 17))
            //                {
            //                    accValue += (accValue + 11 == 17) ? 11 : 1;
            //                    score = accValue;
            //                    if (!once)
            //                        once = true;
            //                    else
            //                        return false;
            //                }
            //                else
            //                    accValue += (int)c.GetValue();
            //            } 
            //            return score < g_hitLimit;



            //if (score == 17 && (int)c.GetValue() != 11)
            //{

            //    return a_dealer.CalcScore() < g_hitLimit;
            //}
            //else
            //{

            //    if ((int)c.GetValue() == 11 || (int)c.GetValue() <= 6)
            //    {

            //        if (score == 17)
            //        {


            //            score -= 10;

            //            return score < g_hitLimit;
            //        }
            //    }
            //}
            

            
