using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Objects.MenuChoices
{
    /// <summary>
    /// Interface of user's choice in menu
    /// </summary>
    interface IMenuChoice
    {
        /// <summary>
        /// Logic of what happening if user make this choice.
        /// </summary>
        void Execute();
    }
}
