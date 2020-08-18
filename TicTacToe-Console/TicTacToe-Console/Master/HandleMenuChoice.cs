using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Master
{
    class HandleMenuChoice : Other.Master
    {
        public void Main()
        {
            Slave.MenuChoicesSetter menuChoicesSetter = new Slave.MenuChoicesSetter();
            int menuChoicesCount = menuChoicesSetter.GetMenuChoicesCount();

            string userChoice = Console.ReadLine();

            Slave.AnalyzeChoice analyzeChoice = new Slave.AnalyzeChoice();
            bool itCorrectChoice = analyzeChoice.ItCorrectChoice(menuChoicesCount, userChoice);

            if(!itCorrectChoice)
            {
                Slave.UserErrors.UserError incorrectVariantChoice = new Slave.UserErrors.IncorrectVariantChoice();

                Slave.UserErrorWriter userErrorWriter = new Slave.UserErrorWriter();
                userErrorWriter.Write(incorrectVariantChoice.GetErrorText());

                Main();
            }

            Other.Master[] menuChoicesExecutor = menuChoicesSetter.GetMenuChoicesExecutor();
            Other.Master executor = menuChoicesExecutor[Convert.ToInt32(userChoice) - 1];
            executor.Main();
        }
    }
}
