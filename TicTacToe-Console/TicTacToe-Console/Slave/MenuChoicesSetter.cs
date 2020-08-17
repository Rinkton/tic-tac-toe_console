using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave
{
    class MenuChoicesSetter
    {
        private readonly string[] menuChoicesDefinition;

        private readonly Other.Master[] menuChoicesExecutor;

        public string[] GetMenuChoicesDefinition()
        {
            return new string[0];
        }

        public Other.Master[] GetMenuChoicesExecutor()
        {
            return null;
        }

        public int GetMenuChoicesCount()
        {
            return 0;
        }
    }
}
