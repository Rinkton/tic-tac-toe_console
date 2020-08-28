using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave.Players
{
    abstract class Player
    {
        public Marks.Mark Mark { get; }

        /// <summary>
        /// If true - it bot and he need grid cells to make decision.
        /// If false - it real human and he don't need grid cells to make decision, 
        /// because all visualized on his monitor.
        /// </summary>
        public bool IAmBot { get; }

        public string GetCellPositionDecision()
        {
            return null;
        }

        public string GetCellPositionDecision(Marks.Mark[,] gridCells)
        {
            return null;
        }
    }
}
