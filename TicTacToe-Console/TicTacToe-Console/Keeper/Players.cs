using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Keeper
{
    class Players
    {
        private Slave.Players.Player firstPlayer;

        private Slave.Players.Player secondPlayer;

        public Slave.Players.Player GetPlayer(bool returnFirstPlayer)
        {
            return null;
        }

        public void SetPlayers(Slave.Players.Player firstPlayer, Slave.Players.Player secondPlayer)
        {
            this.firstPlayer = firstPlayer;
            this.secondPlayer = secondPlayer;
        }
    }
}
