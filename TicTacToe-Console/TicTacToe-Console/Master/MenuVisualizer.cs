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
            Slave.MenuChoicesSetter menuChoicesSetter = new Slave.MenuChoicesSetter();
            string[] menuChoicesDefinition = menuChoicesSetter.GetMenuChoicesDefinition();

            Slave.MenuVisualizer menuVisualizer = new Slave.MenuVisualizer();
            menuVisualizer.VisualizeMenu(menuChoicesDefinition);

            Other.Master handleMenuChoice = new HandleMenuChoice();
            handleMenuChoice.Main();
        }
    }
}
