﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave.Stages
{
    class FirstPlayerIsMove : Stage
    {
        public FirstPlayerIsMove()
        {
            IFinishGame = false;

            Definition = "First player is move!";
        }
    }
}
