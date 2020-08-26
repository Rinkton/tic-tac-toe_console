using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave.UserErrors
{
    class IncorrectVariantChoice : UserError
    {
        public IncorrectVariantChoice()
        {
            ErrorText = "Incorrect variant choice the error! Please, enter number one of offered variants.";
        }
    }
}
