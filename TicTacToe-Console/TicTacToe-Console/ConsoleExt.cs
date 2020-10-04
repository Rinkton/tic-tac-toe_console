using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace TicTacToe_Console
{
    /// <summary>
    /// This class - is Console extension. It support paint console text with using Color the class.
    /// </summary>
    static class ConsoleExt
    {
        /// <summary>
        /// It's just line skip.
        /// </summary>
        public static void Visualize()
        {
            Console.WriteLine();
        }

        /// <summary>
        /// Visualize text of line, coloring it in default color.
        /// </summary>
        /// <param name="value"></param>
        public static void Visualize(string value)
        {
            Console.WriteLine(value, Color.LightGray);
        }

        /// <summary>
        /// Visualize text of line, coloring it in color that you name.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="color"></param>
        public static void Visualize(string value, Color color)
        {
            Console.WriteLine(value, color);
        }
    }
}
