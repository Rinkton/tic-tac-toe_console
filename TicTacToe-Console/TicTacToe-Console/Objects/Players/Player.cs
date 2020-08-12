using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Objects.Players
{
    /// <summary>
    /// Abstract class of type player, that can play
    /// </summary>
    abstract class Player
    {
        public Marks.Mark Mark;

        public Player(Marks.Mark mark)
        {
            Mark = mark;
        }
    }
}
