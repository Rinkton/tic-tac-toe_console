using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Master
{
    class MenuVisualizer : Other.Master
    {
        public void Main()
        {
            Keeper.MenuChoices menuChoicesKeeper = new Keeper.MenuChoices();
            string[] menuChoicesDefinition = menuChoicesKeeper.GetMenuChoicesDefinition();

            Slave.MenuVisualizer menuVisualizer = new Slave.MenuVisualizer();
            menuVisualizer.VisualizeMenu(menuChoicesDefinition);

            Other.Master menuChoiceHandler = new MenuChoiceHandler();
            menuChoiceHandler.Main();
        }
    }
}
