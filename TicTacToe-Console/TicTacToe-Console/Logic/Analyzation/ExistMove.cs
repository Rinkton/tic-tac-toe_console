using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Logic.Analyzation
{
    /// <summary>
    /// Check existing moves yet or no.
    /// </summary>
    class ExistMove
    {
        /// <summary>
        /// Method, which check existing moves yet or no.
        /// </summary>
        /// <param name="cells">Array of cells, that contains what's located in them.</param>
        /// <returns>Existing moves or no.</returns>
        public bool Check(Objects.Marks.Mark[,] cells)
        {
            int countOfEmpty = 0;

            foreach(Objects.Marks.Mark i in cells)
            {
                if(i == null)
                    countOfEmpty++;
            }

            if (countOfEmpty == 0)
                return false;
            else
                return true;
        }
    }
}
