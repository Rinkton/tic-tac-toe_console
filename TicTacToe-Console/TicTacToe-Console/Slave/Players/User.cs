using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave.Players
{
    class User : Player
    {
        public User(Marks.Mark mark) : base(mark)
        {
            IAmComputer = false;
        }

        public override string GetCellPositionDecision()
        {
            return Console.ReadLine();
        }
    }
}
