﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            model.Game g = new model.Game();
            view.IView v = new view.SimpleView(); // new view.SwedishVie();
            controller.PlayGame ctrl = new controller.PlayGame(v);
          
            g.AddSubscribers(ctrl);
            while (ctrl.Play(g));
        }
    }
}
