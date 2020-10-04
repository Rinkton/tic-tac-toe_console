using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console
{
    class VictoryCellPositions
    {
        /// <summary>
        /// There contains victory cells position. 
        /// First array - count of combinations of filled cells at which the game ends 
        /// with the victory of one of the players.
        /// Second array - count of marks that can be engaged to build victory one of the players. 
        /// If one of this combinations been executed - game ended by victory one of the players.
        /// </summary>
        public CellPosition[][] CellPositionsArray { get; }

        public VictoryCellPositions()
        {
            CellPositionsArray = new CellPosition[8][]
            {
                // If you want see all it visual you can find
                // "victoryCellPositions.png" in root directory of the repository

                new CellPosition[3]{ new CellPosition(0, 0), new CellPosition(1, 1), new CellPosition(2, 2) },
                new CellPosition[3]{ new CellPosition(2, 0), new CellPosition(1, 1), new CellPosition(0, 2) },
                new CellPosition[3]{ new CellPosition(0, 0), new CellPosition(1, 0), new CellPosition(2, 0) },
                new CellPosition[3]{ new CellPosition(0, 1), new CellPosition(1, 1), new CellPosition(2, 1) },
                new CellPosition[3]{ new CellPosition(0, 2), new CellPosition(1, 2), new CellPosition(2, 2) },
                new CellPosition[3]{ new CellPosition(0, 0), new CellPosition(0, 1), new CellPosition(0, 2) },
                new CellPosition[3]{ new CellPosition(1, 0), new CellPosition(1, 1), new CellPosition(1, 2) },
                new CellPosition[3]{ new CellPosition(2, 0), new CellPosition(2, 1), new CellPosition(2, 2) }
            };
        }
    }
}
