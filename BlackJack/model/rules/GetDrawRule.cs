using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class PlayerDrawStrategy : IDrawStrategy
    {
        public bool doWin(model.Player player, model.Dealer dealer)
        {
            return player.CalcScore() == dealer.CalcScore();
        }
    }
}
