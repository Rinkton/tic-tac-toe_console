using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console
{
    class MenuChoices
    {
        public string[] MenuChoicesDefinition { get; }

        public IMaster[] MenuChoicesExecutor { get; }

        public MenuChoices()
        {
            MenuChoicesDefinition = new string[]
            {
                "User vs User",
                "User vs Computer"
            };

            MenuChoicesExecutor = new IMaster[]
            {
                new Master.UserVsUserMenuChoice(),
                new Master.UserVsComputerMenuChoice()
            };
        }

        public int GetMenuChoicesCount()
        {
            return MenuChoicesDefinition.Length;
        }
    }
}
