using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console
{
    class CellPosition
    {
        public int X { get; private set; }

        public int Y { get; private set; }

        public CellPosition(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
