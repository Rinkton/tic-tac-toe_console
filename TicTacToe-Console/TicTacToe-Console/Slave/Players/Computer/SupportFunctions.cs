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
        /// Check where need to put own mark to win / prevent to opponent win. (can return empty array)
        /// </summary>
        /// <param name="gridCells"></param>
        /// <param name="checkMark">What mark need to check win at the next move?</param>
        /// <returns></returns>
        private CellPosition[] getLastMoveVariantsToVictory(Marks.Mark[,] gridCells, Marks.Mark checkMark)
        {
            List<CellPosition> possibleDecisionsList = new List<CellPosition>();

            VictoryCellPositions victoryCellPositions = new VictoryCellPositions();

            foreach (CellPosition[] cellPositions in victoryCellPositions.CellPositionsArray)
            {
                int concurrencesCount = 0;
                CellPosition nonConcurrencePos = null;

                #region checks grid cells on concurrence to one of victory cell positions
                foreach (CellPosition pos in cellPositions)
                {
                    if (gridCells[pos.X, pos.Y].GetType() == checkMark.GetType())
                    {
                        concurrencesCount++;
                    }
                    else
                    {
                        nonConcurrencePos = pos;
                    }
                }
                #endregion

                #region checks whether it possible decision, if yes - add it to list
                // (Only one move lacks to win (only one non concurrence)? 
                // Then it need to add in possible decisions)!
                if (concurrencesCount == cellPositions.Length - 1)
                {
                    // And it's missing a move on a cell that is empty?
                    Marks.Mark nonConcurrenceMark = gridCells[nonConcurrencePos.X, nonConcurrencePos.Y];

                    if (nonConcurrenceMark.GetType() == new Marks.Empty().GetType())
                        possibleDecisionsList.Add(nonConcurrencePos);
                }
                #endregion
            }

            CellPosition[] possibleDecisions = possibleDecisionsList.ToArray();

            return possibleDecisions;
        }

        /// <summary>
        /// Give possible decisions (used to find possible corners, center and sides).
        /// </summary>
        /// <param name="allDecisions">All decision between which need find possible decisions.</param>
        /// <param name="gridCells"></param>
        /// <returns></returns>
        private CellPosition[] getPossibleDecisions(CellPosition[] allDecisions, Marks.Mark[,] gridCells)
        {
            List<CellPosition> possibleDecisionsList = new List<CellPosition>();

            foreach (CellPosition pos in allDecisions)
            {
                if (gridCells[pos.X, pos.Y].GetType() == new Marks.Empty().GetType())
                {
                    possibleDecisionsList.Add(pos);
                }
            }

            CellPosition[] possibleDecisions = possibleDecisionsList.ToArray();

            return possibleDecisions;
        }

        private CellPosition getFinalDecision(CellPosition[] possibleDecisions)
        {
            Random rndDecision = new Random();
            int numberOfFinalDecision = rndDecision.Next(possibleDecisions.Length);

            CellPosition finalDecision = possibleDecisions[numberOfFinalDecision];

            return finalDecision;
        }

        /// <summary>
        /// Need to save uniform of decision kind. Bad solution!
        /// </summary>
        /// <param name="cellPositionDecision"></param>
        /// <returns>User-like decision</returns>
        private string convertCellPositionToString(CellPosition cellPositionDecision)
        {
            string convertedCellPositionDecision;

            // +1 - Because normal people count from 1, not 0
            convertedCellPositionDecision = (cellPositionDecision.X + 1) + "" + (cellPositionDecision.Y + 1);

            return convertedCellPositionDecision;
        }
    }
}
