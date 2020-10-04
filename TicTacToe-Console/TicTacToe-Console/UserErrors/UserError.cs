using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.UserErrors
{
    abstract class UserError
    {
        public string ErrorText { get; protected set; }
    }
}
