using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Objects.MenuChoices
{
    /// <summary>
    /// Play with computer choice.
    /// </summary>
    class PlayWithComputer : IMenuChoice
    {
        /// <summary>
        /// Make second player - computer and start the Game.
        /// </summary>
        public void Execute()
        {
            var managGame = new Logic.Management.Game();
            managGame.Main(new Players.User(new Marks.X()), new Players.Computer(new Marks.O()));
        }
    }
}
