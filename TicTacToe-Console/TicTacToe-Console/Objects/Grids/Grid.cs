using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Objects.Grids
{
    /// <summary>
    /// Static class, keeper of array of cells, 3x3
    /// </summary>
    static class Grid
    {
        /// <summary>
        /// Array of cells, that contains what's located in them.
        /// </summary>
        public static Marks.Mark[,] cells = new Marks.Mark[3,3] { { null, null, null },
                                                                   { null, null, null },
                                                                   { null, null, null } };
    }
}
