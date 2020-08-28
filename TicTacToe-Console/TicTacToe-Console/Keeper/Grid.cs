using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Keeper
{
    class Grid
    {
        private Slave.Marks.Mark[,] cells = new Slave.Marks.Mark[3,3]
        {
            { null, null, null },
            { null, null, null },
            { null, null, null }
        };

        public Slave.Marks.Mark[,] GetCells()
        {
            return null;
        }

        public Slave.Marks.Mark GetCell(Slave.CellPosition cellPosition)
        {
            return null;
        }

        public int GetGridSize()
        {
            return 0;
        }

        public void ChangeCell(Slave.CellPosition cellPosition, Slave.Marks.Mark changeOnWhat)
        {

        }
    }
}
