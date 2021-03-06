﻿using BlackJack.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BlackJack.controller
{
    class PlayGame : model.CardDrawObserver
    {


        private view.IView m_view;

        public PlayGame(view.IView v)
        {
            m_view = v;
        }
              
        public bool Play(model.Game a_game)
        {
            
            m_view.DisplayWelcomeMessage();
            
            m_view.DisplayDealerHand(a_game.GetDealerHand(), a_game.GetDealerScore());
            m_view.DisplayPlayerHand(a_game.GetPlayerHand(), a_game.GetPlayerScore());

            if (a_game.IsGameOver())
            {
                m_view.DisplayGameOver(a_game.IsDealerWinner());
            }

            switch((view.Choices)m_view.GetInput())
            {
                case view.Choices.Play:
                    a_game.NewGame();
                    break;
                case view.Choices.Hit:
                    a_game.Hit();
                    break;
                case view.Choices.Stand:
                    a_game.Stand();
                    break;
                case view.Choices.Quit:
                    return false;

                default:
                    break;
            }

            return true;
        }

        public void cardDraw(Card card)
        {
            Thread.Sleep(500);
            m_view.DisplayCard(card);
        }
    }
}
