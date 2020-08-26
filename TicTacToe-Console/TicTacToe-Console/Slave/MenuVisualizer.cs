using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave
{
    class MenuVisualizer
    {
        private readonly string helloText = "Welcome to the Tic-Tac-Toe in Console!";

        public void VisualizeMenu(string[] menuChoicesDefinition)
        {
            visualizeHelloText();
            visualizeMenuChoicesDefinition(menuChoicesDefinition);
        }

        private void visualizeHelloText()
        {
            Console.WriteLine(helloText);
            Console.WriteLine();
        }

        private void visualizeMenuChoicesDefinition(string[] menuChoicesDefinition)
        {
            int menuChoicesCount = menuChoicesDefinition.Length;

            for (int i = 0; i < menuChoicesCount; i++)
                Console.WriteLine(i+1 + ") " + menuChoicesDefinition[i]);
        }
    }
}
