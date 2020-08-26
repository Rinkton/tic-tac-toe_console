using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave.UserErrors
{
    abstract class UserError
    {
        protected string ErrorText;

        public string GetErrorText()
        {
            return ErrorText;
        }
    }
}
