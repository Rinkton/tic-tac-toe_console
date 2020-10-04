using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Master
{
    class UserVsUserMenuChoice : IMaster
    {
        public void Main()
        {
            Marks.Mark x = new Marks.X();
            Marks.Mark o = new Marks.O();
            Keeper.Players.SetPlayers(new Slave.Players.User(x), new Slave.Players.User(o));

            Keeper.Grid.Reset();
            Keeper.Stage.Reset();

            GameVisualizer gameVisualizer = new GameVisualizer();
            gameVisualizer.Main();
        }
    }
}
