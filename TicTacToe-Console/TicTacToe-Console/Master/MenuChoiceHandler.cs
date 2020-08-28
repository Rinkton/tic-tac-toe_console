using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Master
{
    class MenuChoiceHandler : Other.Master
    {
        public void Main()
        {
            Keeper.MenuChoices menuChoicesKeeper = new Keeper.MenuChoices();
            int menuChoicesCount = menuChoicesKeeper.GetMenuChoicesCount();

            string userEntry = Console.ReadLine();

            Slave.EntryCorrectnessChecker entryCorrectnessChecker = new Slave.EntryCorrectnessChecker();
            bool isCorrectChoiceEntry = entryCorrectnessChecker.ItCorrectVariantChoice(userEntry, menuChoicesCount);

            if (!isCorrectChoiceEntry)
            {
                Slave.UserErrors.UserError incorrectVariantChoice;
                incorrectVariantChoice = new Slave.UserErrors.IncorrectVariantChoice();

                Slave.UserErrorWriter userErrorWriter = new Slave.UserErrorWriter();
                userErrorWriter.Write(incorrectVariantChoice.GetErrorText());

                Main();
            }

            Other.Master[] menuChoicesExecutor = menuChoicesKeeper.GetMenuChoicesExecutor();
            Slave.EntryParser entryParser = new Slave.EntryParser();
            Other.Master executor = menuChoicesExecutor[entryParser.ParseVariantChoice(userEntry) - 1];
            executor.Main();
        }
    }
}
