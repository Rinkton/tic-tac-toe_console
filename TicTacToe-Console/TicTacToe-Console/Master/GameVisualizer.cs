using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Master
{
    class GameVisualizer : Other.Master
    {
        public void Main()
        {
            Keeper.Grid gridKeeper = new Keeper.Grid();
            Keeper.Stage stageKeeper = new Keeper.Stage();
            Slave.GameVisualizer gameVisualizer = new Slave.GameVisualizer();
            gameVisualizer.VisualizeGame(gridKeeper.GetCells(), stageKeeper.GetCurrentStageDefinition());

            GameIsEnded gameIsEnded = new GameIsEnded();
            gameIsEnded.Main();
        }
    }
}
