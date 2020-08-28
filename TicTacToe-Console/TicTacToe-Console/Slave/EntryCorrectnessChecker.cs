using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave
{
    class EntryCorrectnessChecker
    {
        public bool ItCorrectVariantChoice(string whatUserEnter, int choicesCount)
        {
            return itNumber(whatUserEnter) && thisNumberInCorrectRange(whatUserEnter, choicesCount);
        }

        public bool ItCorrectCellPosition(string whatUserEnter, int gridSize)
        {
            return false;
        }

        private bool itNumber(string whatUserEnter)
        {
            bool isNotNullOrEmpty = !String.IsNullOrEmpty(whatUserEnter);
            bool isNumber = whatUserEnter.Length == whatUserEnter.Where(c => char.IsDigit(c)).Count();

            return isNumber && isNotNullOrEmpty;
        }

        private bool thisNumberInCorrectRange(string whatUserEnter, int choicesCount)
        {
            bool isNumberInCorrectRange;
            int number = Convert.ToInt32(whatUserEnter);

            if (number > 0 && number <= choicesCount)
                isNumberInCorrectRange = true;
            else
                isNumberInCorrectRange = false;

            return isNumberInCorrectRange;
        }
    }
}
