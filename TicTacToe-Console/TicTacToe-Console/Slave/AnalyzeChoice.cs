using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave
{
    class AnalyzeChoice
    {
        public bool ItCorrectChoice(string whatUserEnter, int choicesCount)
        {
            return itNumber(whatUserEnter) && itNumberInChoicesRange(whatUserEnter, choicesCount);
        }

        private bool itNumber(string whatUserEnter)
        {
            bool isNumber = whatUserEnter.Length == whatUserEnter.Where(c => char.IsDigit(c)).Count();
            return isNumber;
        }

        private bool itNumberInChoicesRange(string whatUserEnter, int choicesCount)
        {
            bool isNumberInChoicesRange;
            int number = Convert.ToInt32(whatUserEnter);

            if (number > 0 && number <= choicesCount)
                isNumberInChoicesRange = true;
            else
                isNumberInChoicesRange = false;

            return isNumberInChoicesRange;
        }
    }
}
