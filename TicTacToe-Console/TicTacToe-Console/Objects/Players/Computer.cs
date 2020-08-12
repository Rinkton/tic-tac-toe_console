using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe_Console.Objects.Marks;

namespace TicTacToe_Console.Objects.Players
{
    /// <summary>
    /// AI.
    /// </summary>
    class Computer : Player
    {
        public Computer(Mark mark) : base(mark) { }
    }
}
