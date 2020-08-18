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
            Slave.PlayersKeeper playersKeeper = new Slave.PlayersKeeper();
            playersKeeper.SetPlayers(new Slave.Players.User(), new Slave.Players.User());

            DataPreparatorForGame dataPreparatorForGame = new DataPreparatorForGame();
            dataPreparatorForGame.Main();
        }
    }
}
