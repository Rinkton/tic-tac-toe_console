using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Keeper
{
    static class Stage
    {
        private static Slave.Stages.Stage currentStage;

        public static void Reset()
        {
            Slave.Stages.Stage startStage = new Slave.Stages.FirstPlayerIsMove();

            currentStage = startStage;
        }

        public static Slave.Stages.Stage GetCurrentStage()
        {
            return currentStage;
        }

        public static string GetCurrentStageDefinition()
        {
            return currentStage.Definition;
        }

        public static void SetVictory()
        {
            if (currentStage.GetType() == new Slave.Stages.FirstPlayerIsMove().GetType())
            {
                currentStage = new Slave.Stages.FirstPlayerWon();
            }
            else if (currentStage.GetType() == new Slave.Stages.SecondPlayerIsMove().GetType())
            {
                currentStage = new Slave.Stages.SecondPlayerWon();
            }
        }

        public static void SetDraw()
        {
            currentStage = new Slave.Stages.Draw();
        }

        public static void SetNextPlayerIsMove()
        {
            if (currentStage.GetType() == new Slave.Stages.FirstPlayerIsMove().GetType())
            {
                currentStage = new Slave.Stages.SecondPlayerIsMove();
            }
            else if (currentStage.GetType() == new Slave.Stages.SecondPlayerIsMove().GetType())
            {
                currentStage = new Slave.Stages.FirstPlayerIsMove();
            }
        }
    }
}
