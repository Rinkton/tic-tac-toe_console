﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave.Stages
{
    class Draw : Stage
    {
        public Draw()
        {
            IFinishGame = true;

            Definition = "Draw!";
        }
    }
}
