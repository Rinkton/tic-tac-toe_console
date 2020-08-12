using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Logic.Analyzation
{
    /// <summary>
    /// Determine what stage now.
    /// </summary>
    class CurrentStage
    {
        /// <summary>
        /// Method, which determine what stage now.
        /// </summary>
        /// <param name="cells">Cells of the grid.</param>
        /// <param name="firstPlayerIsMove">Now first player is move?</param>
        /// <returns>Current stage.</returns>
        public Objects.Stages.Stage Determine(Objects.Marks.Mark[,] cells, bool firstPlayerIsMove)
        {
            var analyzExistMove = new ExistMove();
            bool existMove = analyzExistMove.Check(cells);
        }
    }
}
