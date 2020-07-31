using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Logic.Visualization
{
    /// <summary>
    /// Class, which visualize menu.
    /// </summary>
    class Menu
    {
        /// <summary>
        /// Method of menu visualization.
        /// </summary>
        /// <param name="welcomeText">Text, which introduce the program.</param>
        /// <param name="choicesText">Text of choices in menu.</param>
        public void Visualize(string welcomeText, string[] choicesText)
        {
            Console.WriteLine(welcomeText);
            Console.WriteLine();

            int i = 1;

            foreach(string s in choicesText)
            {
                Console.WriteLine(i + ") " + s);

                i++;
            }
        }
    }
}
