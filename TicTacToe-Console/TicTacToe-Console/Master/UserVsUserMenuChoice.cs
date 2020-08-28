using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Master
{
    class UserVsUserMenuChoice : Other.Master
    {
        public void Main()
        {
            Keeper.Players playersKeeper = new Keeper.Players();
            playersKeeper.SetPlayers(new Slave.Players.User(), new Slave.Players.User());

            GameVisualizer gameVisualizer = new GameVisualizer();
            gameVisualizer.Main();
        }
    }
}
