using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Logic.Analyzation
{
    /// <summary>
    /// Check what to do based on user-written variant.
    /// </summary>
    class ChoiceMenu
    {
        /// <summary>
        /// Method, which check what to do based on user-written variant.
        /// </summary>
        /// <param name="choice">Choice of user.</param>
        public Objects.MenuChoices.IMenuChoice CheckChoice(string choice)
        {
            if(choice == "1")
            {
                return new Objects.MenuChoices.PlayWithPlayer();
            }
            else if (choice == "2")
            {
                return new Objects.MenuChoices.PlayWithComputer();
            }
            else if (choice == "3")
            {
                return new Objects.MenuChoices.Quit();
            }
            else
            {
                return null;
            }
        }
    }
}
