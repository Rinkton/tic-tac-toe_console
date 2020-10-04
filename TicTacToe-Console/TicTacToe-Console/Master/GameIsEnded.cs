using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Master
{
    class GameIsEnded : IMaster
    {
        public void Main()
        {
            Slave.Stages.Stage currentStage = Keeper.Stage.GetCurrentStage();

            if (currentStage.IFinishGame == true)
            {
                Console.ReadKey();

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
