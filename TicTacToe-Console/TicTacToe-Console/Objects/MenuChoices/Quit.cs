using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Objects.MenuChoices
{
    /// <summary>
    /// Quit the game choice.
    /// </summary>
    class Quit : IMenuChoice
    {
        /// <summary>
        /// Close the program
        /// </summary>
        public void Execute()
        {
            Environment.Exit(0);
        }
    }
}
