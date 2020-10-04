using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave.Stages
{
    class SecondPlayerIsMove : Stage
    {
        public SecondPlayerIsMove()
        {
            IFinishGame = false;

            Definition = "Second player is move!";
        }
    }
}
