using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Logic.Other
{
    /// <summary>
    /// Start of the program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// There is start the program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var managMenu = new Management.Menu();
            managMenu.Main();
        }
    }
}
