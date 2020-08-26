using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Slave
{
    class PlayersKeeper
    {
        private Players.Player firstPlayer;

        private Players.Player secondPlayer;

        public void SetPlayers(Players.Player firstPlayer, Players.Player secondPlayer)
        {
            setFirstPlayer(firstPlayer);
            setSecondPlayer(secondPlayer);
        }

        private void setFirstPlayer(Players.Player firstPlayer)
        {
            this.firstPlayer = firstPlayer;
        }

        private void setSecondPlayer(Players.Player secondPlayer)
        {
            this.secondPlayer = secondPlayer;
        }
    }
}
