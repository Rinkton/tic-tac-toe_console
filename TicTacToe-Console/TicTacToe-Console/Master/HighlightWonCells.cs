using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Master
{
    class HighlightWonCells : IMaster
    {
        public void Main()
        {
            Slave.GridAnalyzer gridAnalyzer = new Slave.GridAnalyzer();
            CellPosition[] wonCellsPositions = gridAnalyzer.GetWonCellsPosition(Keeper.Grid.GetCells());

            Marks.Mark[,] gridCells = Keeper.Grid.GetCells();

            foreach (CellPosition pos in wonCellsPositions)
            {
                Keeper.Grid.PaintCell(pos);
            }

            GameVisualizer gameVisualizer = new GameVisualizer();
            gameVisualizer.Main();
        }
    }
}
