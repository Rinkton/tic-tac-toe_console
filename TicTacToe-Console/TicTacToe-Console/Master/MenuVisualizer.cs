using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Master
{
    class MenuVisualizer : IMaster
    {
        public void Main()
        {
            MenuChoices menuChoices = new MenuChoices();
            string[] menuChoicesDefinition = menuChoices.MenuChoicesDefinition;

            Slave.MenuVisualizer menuVisualizer = new Slave.MenuVisualizer();
            menuVisualizer.VisualizeMenu(menuChoicesDefinition);

            MenuChoiceHandler menuChoiceHandler = new MenuChoiceHandler();
            menuChoiceHandler.Main();
        }
    }
}
