using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave.Players.Computer
{
    partial class Base : Player
    {
        /// <summary>
        /// It need only to find possible moves to prevent to opponent win 
        /// (this variable have weak cohesion - BAD)
        /// </summary>
        private Marks.Mark opponentGameMark;

        public Base(Marks.Mark mark) : base(mark)
        {
            IAmComputer = true;
        }

        public override string GetCellPositionDecision(Marks.Mark[,] gridCells, Marks.Mark opponentGameMark)
        {
            this.opponentGameMark = opponentGameMark;

            tryFindPossibleDecisions[] tryFindPossibleDecisionsInstances = new tryFindPossibleDecisions[5]
            {
                possibleDecisionsToWin,
                possibleDecisionsToPreventOpponentWin,
                possibleDecisionsToTakeCorner,
                possibleDecisionsToTakeCenter,
                possibleDecisionsToTakeSides
            };
            makeFinalDecision[] makeFinalDecisionInstances = new makeFinalDecision[5]
            {
                makeFinalDecisionToWin,
                makeFinalDecisionToPreventOpponentWin,
                makeFinalDecisionSelectionCorners,
                makeFinalDecisionSelectionCenter,
                makeFinalDecisionSelectionSides
            };

            CellPosition finalDecision = null;

            for (int i = 0; i < tryFindPossibleDecisionsInstances.Length; i++)
            {
                CellPosition[] possibleDecisions = tryFindPossibleDecisionsInstances[i](gridCells);

                if (possibleDecisions.Length != 0)
                {
                    finalDecision = makeFinalDecisionInstances[i](possibleDecisions);
                    break;
                }
            }

            string convertedFinalDecision = convertCellPositionToString(finalDecision);

            return convertedFinalDecision;
        }
    }
}
