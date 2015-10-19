using BlackJack.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.controller
{
    class PlayGame : model.CardDrawObserver
    {

       

        private int input;

        private view.IView m_view;

        public bool Play(model.Game a_game, view.IView a_view)
        {
            m_view = a_view;
            m_view.DisplayWelcomeMessage();
            
            m_view.DisplayDealerHand(a_game.GetDealerHand(), a_game.GetDealerScore());
            m_view.DisplayPlayerHand(a_game.GetPlayerHand(), a_game.GetPlayerScore());

            if (a_game.IsGameOver())
            {
                a_view.DisplayGameOver(a_game.IsDealerWinner());
            }

            input = a_view.GetInput();

            if (NewGame())
            {
                a_game.NewGame();
            }
            else if (Hit())
            {
                a_game.Hit();
            
                
            }
            else if (Stand())
            {
                a_game.Stand();

            }

            return input != 'q';
        }

        public bool NewGame()
        {

            if (input == 'p')
            {
                return true;
            }

            return false;
        }

        public bool Hit()
        {
            if (input == 'h')
            {
                return true;
            }

            return false;
        }

        public bool Stand()
        {
            if (input == 's')
            {
                return true;
            }

            return false;
        }

        public void cardDraw(Card card)
        {
           
            m_view.DisplayCard(card);

        }
    }
}
