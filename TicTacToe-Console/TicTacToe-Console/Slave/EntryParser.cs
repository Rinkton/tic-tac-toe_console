using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave
{
    class EntryParser
    {
        public int ParseVariantChoice(string whatUserEnter)
        {
            return Convert.ToInt32(whatUserEnter);
        }

        /// <summary>
        /// Parse player entry in cell position 
        /// (If entry is not correct cell position, then exception appeared!)
        /// </summary>
        /// <param name="whatUserEnter"></param>
        /// <returns></returns>
        public CellPosition ParseCellPosition(string whatPlayerEnter)
        {
            char[] symbols = whatPlayerEnter.ToCharArray();

            // " - 1" - because computer count from 0, no 1
            int x = Convert.ToInt32((symbols[0] - '0') - 1);
            int y = Convert.ToInt32((symbols[1] - '0') - 1);

            CellPosition cellPosition = new CellPosition(x, y);

            return cellPosition;
        }
    }
}
