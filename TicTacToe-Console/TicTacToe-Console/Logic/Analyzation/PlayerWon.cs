using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Logic.Analyzation
{
    /// <summary>
    /// Check, won player, that make last move.
    /// </summary>
    class PlayerWon
    {
        /// <summary>
        /// There described win positions.
        /// </summary>
        private readonly bool[][,] WinPositions = new bool[8][,] { new bool[3,3] { { true, false, false },
                                                                                   { true, false, false },
                                                                                   { true, false, false } },

                                                                   new bool[3,3] { { false, true, false },
                                                                                   { false, true, false },
                                                                                   { false, true, false } },

                                                                   new bool[3,3] { { false, false, true },
                                                                                   { false, false, true },
                                                                                   { false, false, true } },

                                                                   new bool[3,3] { { true, true, true },
                                                                                   { false, false, false },
                                                                                   { false, false, false } },

                                                                   new bool[3,3] { { false, false, false },
                                                                                   { true, true, true },
                                                                                   { false, false, false } },

                                                                   new bool[3,3] { { false, false, false },
                                                                                   { false, false, false },
                                                                                   { true, true, true } },

                                                                   new bool[3,3] { { true, false, false },
                                                                                   { false, true, false },
                                                                                   { false, false, true } },

                                                                   new bool[3,3] { { false, false, true },
                                                                                   { false, true, false },
                                                                                   { true, false, false } } };

        /// <summary>
        /// Method, which check, won player, that make last move.
        /// </summary>
        /// <param name="cells">Cells of the grid.</param>
        /// <param name="playerNowIsMove">PLayer, which now is move.</param>
        /// <returns>Won player, that make last move.</returns>
        public bool Check(Objects.Marks.Mark[,] cells, Objects.Players.Player playerNowIsMove)
        {
            // OKAY, NOW NEED TO WRITE CHECK WON PLAYER OR NOT. BUT NOW I UNDERSTAND NOTHING, MAYBE NEED REWRITE IT ALL?!
            Objects.Marks.Mark perhapsWonMark;
        }
    }
}
