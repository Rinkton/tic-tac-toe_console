using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave.Marks
{
    abstract class Mark
    {
        private readonly ConsoleColor normalColor = ConsoleColor.Gray;

        private readonly ConsoleColor wonColor = ConsoleColor.White;

        public void Won()
        {

        }
    }
}
