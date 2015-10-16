using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.controller
{
    class PlayGame
    {
        private int input;

        public bool Play(model.Game a_game, view.IView a_view)
        {

            a_view.DisplayWelcomeMessage();
            
            a_view.DisplayDealerHand(a_game.GetDealerHand(), a_game.GetDealerScore());
            a_view.DisplayPlayerHand(a_game.GetPlayerHand(), a_game.GetPlayerScore());

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
    }
}
