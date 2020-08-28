using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Master
{
    class HighlightWonCells : Other.Master
    {
        public void Main()
        {
            Slave.GridAnalyzer gridAnalyzer = new Slave.GridAnalyzer();
            Keeper.Grid gridKeeper = new Keeper.Grid();
            Slave.CellPosition[] wonCellsPositions = gridAnalyzer.GetWonCellsPosition(gridKeeper.GetCells());

            foreach (Slave.CellPosition position in wonCellsPositions)
            {
                Slave.Marks.Mark wonMark = gridKeeper.GetCell(position);
                wonMark.Won();
                gridKeeper.ChangeCell(position, wonMark);
            }

            GameVisualizer gameVisualizer = new GameVisualizer();
            gameVisualizer.Main();
        }
    }
}
