using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave
{
    class GridAnalyzer
    {
        public bool ItVictory(Marks.Mark[,] gridCells)
        {
            CellPosition[] wonCellsPosition = GetWonCellsPosition(gridCells);

            return wonCellsPosition.Length > 0;
        }

        public bool ItDraw(Marks.Mark[,] gridCells)
        {
            foreach (Marks.Mark cell in gridCells)
            {
                if (cell.GetType() == new Marks.Empty().GetType())
                {
                    return false;
                }
            }

            return true;
        }

        #region Get won cells position
        public CellPosition[] GetWonCellsPosition(Marks.Mark[,] gridCells)
        {
            VictoryCellPositions victoryCellPositions = new VictoryCellPositions();

            foreach (CellPosition[] cellPositions in victoryCellPositions.CellPositionsArray)
            {
                bool someCellIsEmpty = someCellAtVictoryPositionsIsEmpty(cellPositions, gridCells);

                if (someCellIsEmpty == false)
                {
                    Marks.Mark[] checkCells = getMarksOnCellPositions(cellPositions, gridCells);

                    bool allMarksAreSame = allMarksAreTheSame(checkCells);

                    if (allMarksAreSame == true)
                    {
                        return cellPositions;
                    }
                }
            }

            return new CellPosition[0];
        }

        private bool someCellAtVictoryPositionsIsEmpty(CellPosition[] cellPositions, Marks.Mark[,] gridCells)
        {
            foreach (CellPosition pos in cellPositions)
            {
                if (gridCells[pos.X, pos.Y].GetType() == new Marks.Empty().GetType())
                {
                    return true;
                }
            }

            return false;
        }

        private Marks.Mark[] getMarksOnCellPositions(CellPosition[] cellPositions, Marks.Mark[,] gridCells)
        {
            Marks.Mark[] checkCells = new Marks.Mark[cellPositions.Length];

            int i = 0;

            foreach (CellPosition pos in cellPositions)
            {
                checkCells[i] = gridCells[pos.X, pos.Y];

                i++;
            }

            return checkCells;
        }

        private bool allMarksAreTheSame(Marks.Mark[] checkCells)
        {
            for (int j = 0; j + 1 < checkCells.Length; j++)
            {
                if (checkCells[j].GetType() != checkCells[j + 1].GetType())
                {
                    return false;
                }
            }

            return true;
        }
        #endregion
    }
}
