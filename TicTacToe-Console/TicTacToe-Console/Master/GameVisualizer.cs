using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Master
{
    class GameVisualizer : IMaster
    {
        public void Main()
        {
            Slave.GameVisualizer gameVisualizer = new Slave.GameVisualizer();
            gameVisualizer.VisualizeGame(Keeper.Grid.GetCells(), Keeper.Stage.GetCurrentStageDefinition());

            GameIsEnded gameIsEnded = new GameIsEnded();
            gameIsEnded.Main();
        }
    }
}
