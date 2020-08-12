using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Objects.Marks
{
    /// <summary>
    /// Abstract class of type marks on grid (X or O)
    /// </summary>
    abstract class Mark
    {
        /// <summary>
        /// In this round this mark belong to first player?
        /// </summary>
        public bool belongFirstPlayer;
    }
}
