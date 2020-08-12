using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Logic.Management
{
    /// <summary>
    /// Manage work of game.
    /// </summary>
    class Game
    {
        public void Main(Objects.Players.Player firstPlayer, Objects.Players.Player secondPlayer)
        {
            Console.Clear();

            bool firstPlayerIsMove = true;

            var analyzCurrentStage = new Analyzation.CurrentStage();
            analyzCurrentStage.Determine(Objects.Grids.Grid.cells, firstPlayerIsMove);
        }
    }
}
