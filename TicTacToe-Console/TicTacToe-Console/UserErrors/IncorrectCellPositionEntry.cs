using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.UserErrors
{
    class IncorrectCellPositionEntry : UserError
    {
        public IncorrectCellPositionEntry()
        {
            ErrorText = "Incorrect cell position entry the error! Please, enter a position like \"XY\". " +
                        "For example: \"13\". It meaning put mark on 1 on X, 3 on Y, " +
                        "i.e. in down left corner of the grid. You did the above, but anyway this error " +
                        "displayed? So, perhaps, you choose cell, on what already exist some mark.";
        }
    }
}
