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
        /// Choose one of cell positions on what player can move.
        /// </summary>
        /// <param name="possibleDecisions"></param>
        /// <returns>Final cell position move.</returns>
        delegate CellPosition makeFinalDecision(CellPosition[] possibleDecisions);

        #region makeFinalDecision - delegate instances
        private CellPosition makeFinalDecisionToWin(CellPosition[] possibleDecisions)
        {
            return getFinalDecision(possibleDecisions);
        }

        private CellPosition makeFinalDecisionToPreventOpponentWin(CellPosition[] possibleDecisions)
        {
            return getFinalDecision(possibleDecisions);
        }

        private CellPosition makeFinalDecisionSelectionCorners(CellPosition[] possibleDecisions)
        {
            return getFinalDecision(possibleDecisions);
        }

        private CellPosition makeFinalDecisionSelectionCenter(CellPosition[] possibleDecisions)
        {
            return getFinalDecision(possibleDecisions);
        }

        private CellPosition makeFinalDecisionSelectionSides(CellPosition[] possibleDecisions)
        {
            return getFinalDecision(possibleDecisions);
        }
        #endregion
    }
}
