using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Keeper
{
    class MenuChoices
    {
        private readonly string[] menuChoicesDefinition = new string[]
        {
            "User vs User",
            "User vs Computer"
        };

        private readonly Other.Master[] menuChoicesExecutor = new Other.Master[] 
        {
            new Master.UserVsUserMenuChoice(),
            new Master.UserVsComputerMenuChoice()
        };

        public string[] GetMenuChoicesDefinition()
        {
            return menuChoicesDefinition;
        }

        public Other.Master[] GetMenuChoicesExecutor()
        {
            return menuChoicesExecutor;
        }

        public int GetMenuChoicesCount()
        {
            return menuChoicesDefinition.Length;
        }
    }
}
