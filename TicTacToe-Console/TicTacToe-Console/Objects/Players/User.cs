using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe_Console.Objects.Marks;

namespace TicTacToe_Console.Objects.Players
{
    /// <summary>
    /// User.
    /// </summary>
    class User : Player
    {
        public User(Mark mark) : base(mark) { }
    }
}
