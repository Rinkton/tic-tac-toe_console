using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave.Players.Computer
{
    partial class Base
    {
        /// <summary>
        /// Try to find cell positions on what player can move.
        /// </summary>
        /// <param name="gridCells"></param>
        /// <returns>List of finded cell positions to move (it can be empty).</returns>
        delegate CellPosition[] tryFindPossibleDecisions(Marks.Mark[,] gridCells);

        #region tryFindPossibleDecisions - delegate instances
        private CellPosition[] possibleDecisionsToWin(Marks.Mark[,] gridCells)
        {
            CellPosition[] possibleDecisions = getLastMoveVariantsToVictory(gridCells, GameMark);

            return possibleDecisions;
        }

        private CellPosition[] possibleDecisionsToPreventOpponentWin(Marks.Mark[,] gridCells)
        {
            CellPosition[] possibleDecisions = getLastMoveVariantsToVictory(gridCells, opponentGameMark);

            return possibleDecisions;
        }

        private CellPosition[] possibleDecisionsToTakeCorner(Marks.Mark[,] gridCells)
        {
            CellPosition[] cornersPosition = new CellPosition[4]
            {
                new CellPosition(0, 0),
                new CellPosition(2, 0),
                new CellPosition(2, 2),
                new CellPosition(0, 2)
            };

            CellPosition[] possibleDecisions = getPossibleDecisions(cornersPosition, gridCells);

            return possibleDecisions;
        }

        private CellPosition[] possibleDecisionsToTakeCenter(Marks.Mark[,] gridCells)
        {
            CellPosition[] centerPosition = new CellPosition[1]
            {
                new CellPosition(1, 1)
            };

            CellPosition[] possibleDecisions = getPossibleDecisions(centerPosition, gridCells);

            return possibleDecisions;
        }

        private CellPosition[] possibleDecisionsToTakeSides(Marks.Mark[,] gridCells)
        {
            CellPosition[] sidesPosition = new CellPosition[4]
            {
                new CellPosition(1, 0),
                new CellPosition(2, 1),
                new CellPosition(1, 2),
                new CellPosition(0, 1)
            };

            CellPosition[] possibleDecisions = getPossibleDecisions(sidesPosition, gridCells);

            return possibleDecisions;
        }
        #endregion
    }
}
