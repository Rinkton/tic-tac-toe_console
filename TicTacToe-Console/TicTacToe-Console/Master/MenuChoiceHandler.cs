using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Master
{
    class MenuChoiceHandler : IMaster
    {
        public void Main()
        {
            MenuChoices menuChoices = new MenuChoices();
            int menuChoicesCount = menuChoices.GetMenuChoicesCount();

            string userEntry = Console.ReadLine();

            Slave.EntryCorrectnessChecker entryCorrectnessChecker = new Slave.EntryCorrectnessChecker();
            UserErrors.UserError error = entryCorrectnessChecker.ItCorrectVariantChoice(userEntry, menuChoicesCount);

            if (error.GetType() != new UserErrors.Null().GetType())
            {
                Slave.UserErrorWriter userErrorWriter = new Slave.UserErrorWriter();
                userErrorWriter.Write(error.ErrorText);

                Main();
            }

            IMaster[] menuChoicesExecutor = menuChoices.MenuChoicesExecutor;
            Slave.EntryParser entryParser = new Slave.EntryParser();
            IMaster executor = menuChoicesExecutor[entryParser.ParseVariantChoice(userEntry) - 1];
            executor.Main();
        }
    }
}
