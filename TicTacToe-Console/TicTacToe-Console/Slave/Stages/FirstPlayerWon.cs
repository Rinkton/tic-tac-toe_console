﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave.Stages
{
    class FirstPlayerWon : Stage
    {
        public FirstPlayerWon()
        {
            IFinishGame = true;

            Definition = "First player won!";
        }
    }
}
