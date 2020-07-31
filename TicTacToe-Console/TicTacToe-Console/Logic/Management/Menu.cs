using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Logic.Management
{
    /// <summary>
    /// Manage work of menu.
    /// </summary>
    class Menu
    {
        /// <summary>
        /// Text, which salaam the user at the enterance of game.
        /// </summary>
        private readonly string welcomeText = "Welcome to Tic-Tac-Toe in the Console!";

        /// <summary>
        /// Text, which display what game mode user can select.
        /// </summary>
        private readonly string[] choicesText = new string[3] {"Play with a second player",
                                                               "Play with a computer",
                                                               "Quit the game"};

        /// <summary>
        /// This method manage work of menu.
        /// </summary>
        public void Main()
        {
            Console.Clear();

            var visMenu = new Visualization.Menu();
            visMenu.Visualize(welcomeText, choicesText);

            var analyzChoiceMenu = new Analyzation.ChoiceMenu();
            var choiceExecutor = analyzChoiceMenu.CheckChoice(Console.ReadLine());

            if (choiceExecutor == null)
                Main();

            choiceExecutor.Execute();
        }
    }
}
