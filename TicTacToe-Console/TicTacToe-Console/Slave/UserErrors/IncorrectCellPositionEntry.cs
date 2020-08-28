using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave.UserErrors
{
    class IncorrectCellPositionEntry : UserError
    {
        public IncorrectCellPositionEntry()
        {
            ErrorText = "Incorrect cell position entry the error! Please, enter a position like \"X Y\"";
        }
    }
}
