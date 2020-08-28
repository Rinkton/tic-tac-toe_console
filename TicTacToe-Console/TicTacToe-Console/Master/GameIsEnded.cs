using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Master
{
    class GameIsEnded : Other.Master
    {
        public void Main()
        {
            Keeper.Stage stageKeeper = new Keeper.Stage();
            Slave.Stages.Stage currentStage = stageKeeper.GetCurrentStage();

            if (currentStage.IFinishGame == true)
            {
                MenuVisualizer menuVisualizer = new MenuVisualizer();
                menuVisualizer.Main();
            }
            else
            {
                GameChoiceHandler gameChoiceHandler = new GameChoiceHandler();
                gameChoiceHandler.Main();
            }
        }
    }
}
