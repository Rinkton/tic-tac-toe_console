using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave
{
    class EntryCorrectnessChecker
    {
        #region it correct variant choice?
        public UserErrors.UserError ItCorrectVariantChoice(string whatUserEnter, int choicesCount)
        {
            if (itNumber(whatUserEnter) && thisNumberInCorrectRange(whatUserEnter, choicesCount))
            {
                return new UserErrors.Null();
            }
            else
            {
                return new UserErrors.IncorrectVariantChoice();
            }
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
        #endregion

        #region it correct cell position? (string, that player enter is existing cell position)
        public UserErrors.UserError ItCorrectCellPosition(string whatPlayerEnter, Marks.Mark[,] gridCells)
        {
            char[] symbols = whatPlayerEnter.ToCharArray();
            const int countOfGridVectors = 2;

            if (!itHaveMinimalLenght(symbols, countOfGridVectors))
            {
                return new UserErrors.IncorrectCellPositionEntry();
            }

            char[] firstSymbols = new char[]
            {
                symbols[0],
                symbols[1]
            };

            if (!itAllIsNumber(firstSymbols))
            {
                return new UserErrors.IncorrectCellPositionEntry();
            }

            // " - 1" - because computer count from 0, no 1
            int x = Convert.ToInt32((symbols[0] - '0') - 1);
            int y = Convert.ToInt32((symbols[1] - '0') - 1);

            CellPosition cellPosition = new CellPosition(x, y);

            if (!cellPositionInCorrectRange(cellPosition, gridCells))
            {
                return new UserErrors.IncorrectCellPositionEntry();
            }

            if (!chosenCellIsEmpty(gridCells, cellPosition))
            {
                return new UserErrors.IncorrectCellPositionEntry();
            }

            return new UserErrors.Null();
        }

        private bool itHaveMinimalLenght(char[] symbols, int countOfGridVectors)
        {
            if (symbols.Length < countOfGridVectors)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool itAllIsNumber(char[] firstSymbols)
        {
            foreach (char symbol in firstSymbols)
            {
                if (itNumber(symbol) == false)
                {
                    return false;
                }
            }

            return true;
        }

        private bool cellPositionInCorrectRange(CellPosition pos, Marks.Mark[,] gridCells)
        {
            // " - 1" - because computer count from 0, no 1
            if (pos.X > gridCells.GetLength(0) - 1 || pos.Y > gridCells.GetLength(1) - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool chosenCellIsEmpty(Marks.Mark[,] gridCells, CellPosition pos)
        {
            if (gridCells[pos.X, pos.Y].GetType() != new Marks.Empty().GetType())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region support functions
        private bool itNumber(string whatUserEnter)
        {
            bool isNotNullOrEmpty = !string.IsNullOrEmpty(whatUserEnter);
            bool isNumber = whatUserEnter.Length == whatUserEnter.Where(c => char.IsDigit(c)).Count();

            return isNumber && isNotNullOrEmpty;
        }

        private bool itNumber(char symbol)
        {
            bool isNumber = char.IsDigit(symbol);

            return isNumber;
        }
        #endregion
    }
}
