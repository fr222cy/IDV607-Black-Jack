using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class RulesFactory
    {
        public IHitStrategy GetHitRule()
        {
            return new BasicHitStrategy();
        }

        public IHitStrategy GetSoft17Rule()
        {
            return new Soft17HitStrategy();
        }

        public INewGameStrategy GetNewGameRule()
        {
            return new AmericanNewGameStrategy();
        }

        public IDrawStrategy GetDrawRule()
        {
            return new PlayerDrawStrategy();
        }
    }
}
