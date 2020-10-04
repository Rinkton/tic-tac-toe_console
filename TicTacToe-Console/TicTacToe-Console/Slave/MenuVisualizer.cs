using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace TicTacToe_Console.Slave
{
    class MenuVisualizer
    {
        private readonly string helloText = "Welcome to the Tic-Tac-Toe in Console!";

        public void VisualizeMenu(string[] menuChoicesDefinition)
        {
            Console.Clear();

            visualizeHelloText();
            visualizeMenuChoicesDefinition(menuChoicesDefinition);
        }

        private void visualizeHelloText()
        {
            ConsoleExt.Visualize(helloText);
            ConsoleExt.Visualize();
        }

        private void visualizeMenuChoicesDefinition(string[] menuChoicesDefinition)
        {
            int menuChoicesCount = menuChoicesDefinition.Length;

            for (int i = 0; i < menuChoicesCount; i++)
                ConsoleExt.Visualize(i+1 + ") " + menuChoicesDefinition[i]);
        }
    }
}
