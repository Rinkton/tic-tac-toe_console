using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Keeper
{
    static class Players
    {
        private static Slave.Players.Player firstPlayer;

        private static Slave.Players.Player secondPlayer;

        public static Slave.Players.Player GetPlayer(bool returnFirstPlayer)
        {
            if (returnFirstPlayer)
                return firstPlayer;
            else
                return secondPlayer;
        }

        public static void SetPlayers(Slave.Players.Player firstPlayer, Slave.Players.Player secondPlayer)
        {
            Players.firstPlayer = firstPlayer;
            Players.secondPlayer = secondPlayer;
        }
    }
}
