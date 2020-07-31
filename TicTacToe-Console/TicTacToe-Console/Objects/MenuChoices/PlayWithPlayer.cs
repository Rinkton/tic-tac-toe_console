using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Objects.MenuChoices
{
    /// <summary>
    /// Play with other player choice.
    /// </summary>
    class PlayWithPlayer : IMenuChoice
    {
        /// <summary>
        /// Make second player - other player and start the Game.
        /// </summary>
        public void Execute()
        {
            var managGame = new Logic.Management.Game();
            managGame.Main(new Players.Player(), new Players.Player());
        }
    }
}
