using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave.Players
{
    abstract class Player
    {
        /// <summary>
        /// Player's mark on this game party.
        /// </summary>
        public Marks.Mark GameMark { get; }

        /// <summary>
        /// If true - it bot and he need grid cells to make decision.
        /// If false - it real human and he don't need grid cells to make decision, 
        /// because all visualized on his monitor.
        /// </summary>
        public bool IAmComputer { get; protected set; }

        public Player(Marks.Mark mark)
        {
            GameMark = mark;
        }

        public virtual string GetCellPositionDecision()
        {
            return "";
        }

        public virtual string GetCellPositionDecision(Marks.Mark[,] gridCells, Marks.Mark opponentGameMark)
        {
            return "";
        }
    }
}
