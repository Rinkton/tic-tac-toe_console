using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.UserErrors
{
    /// <summary>
    /// Null Object pattern. Meaning, that errors is no.
    /// </summary>
    class Null : UserError
    {
        public Null()
        {
            ErrorText = "";
        }
    }
}
