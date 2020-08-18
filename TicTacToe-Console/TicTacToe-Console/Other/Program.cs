using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Other
{
    class Program
    {
        public static void Main()
        {
            Master menuVisualizer = new TicTacToe_Console.Master.MenuVisualizer();
            menuVisualizer.Main();
        }
    }
}
