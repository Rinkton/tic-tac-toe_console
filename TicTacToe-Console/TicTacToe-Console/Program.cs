using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console
{
    class Program
    {
        public static void Main()
        {
            Master.MenuVisualizer menuVisualizer = new Master.MenuVisualizer();
            menuVisualizer.Main();
        }
    }
}
