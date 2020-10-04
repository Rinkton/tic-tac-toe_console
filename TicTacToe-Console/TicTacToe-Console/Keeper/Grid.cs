using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Keeper
{
    static class Grid
    {
        private static Marks.Mark[,] currentCells;

        public static void Reset()
        {
            Marks.Mark[,] startCells = new Marks.Mark[3, 3]
            {
                { new Marks.Empty(), new Marks.Empty(), new Marks.Empty() },
                { new Marks.Empty(), new Marks.Empty(), new Marks.Empty() },
                { new Marks.Empty(), new Marks.Empty(), new Marks.Empty() }
            };

            currentCells = startCells;
        }

        public static Marks.Mark[,] GetCells()
        {
            return currentCells;
        }

        public static void ChangeCell(CellPosition cellPosition, Marks.Mark changeOnWhat)
        {
            currentCells[cellPosition.X, cellPosition.Y] = changeOnWhat;
        }

        public static void PaintCell(CellPosition cellPosition)
        {
            currentCells[cellPosition.X, cellPosition.Y].Won();
        }
    }
}
