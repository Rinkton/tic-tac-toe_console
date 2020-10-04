﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave.Stages
{
    abstract class Stage
    {
        public bool IFinishGame { get; protected set;  }

        public string Definition { get; protected set; }
    }
}
