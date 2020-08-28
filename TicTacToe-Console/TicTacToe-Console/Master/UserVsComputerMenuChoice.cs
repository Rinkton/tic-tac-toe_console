using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Master
{
    class UserVsComputerMenuChoice : Other.Master
    {
        public void Main()
        {
            Keeper.Players playersKeeper = new Keeper.Players();
            playersKeeper.SetPlayers(new Slave.Players.User(), new Slave.Players.Computer());

            GameVisualizer gameVisualizer = new GameVisualizer();
            gameVisualizer.Main();
        }
    }
}
