﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    public class Player
    {
        public string Name { get; set; }
        public Queue<Card> Deck { get; set; }
    }
}
