using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave
{
    class UserErrorWriter
    {
        private readonly ConsoleColor errorColor = ConsoleColor.Red;

        public void Write(string errorText)
        {
            Console.ForegroundColor = errorColor;
            Console.WriteLine("ERROR: " + errorText);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
