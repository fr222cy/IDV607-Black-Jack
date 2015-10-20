using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    interface IDrawStrategy
    {
        bool doWin(model.Player player, model.Dealer dealer);
    }
}
