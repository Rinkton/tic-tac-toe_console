using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Master
{
    class GameChoiceHandler : IMaster
    {
        public void Main()
        {
            Slave.Stages.Stage currentStage = Keeper.Stage.GetCurrentStage();
            bool firstPlayerNowIsMove = currentStage.GetType() == new Slave.Stages.FirstPlayerIsMove().GetType();

            Slave.Players.Player playerThatNowIsMove = Keeper.Players.GetPlayer(firstPlayerNowIsMove);

            Marks.Mark[,] gridCells = Keeper.Grid.GetCells();

            string playerEntry;

            if (playerThatNowIsMove.IAmComputer == true)
            {
                // Get opponent of player, that now is move.
                Slave.Players.Player opponent = Keeper.Players.GetPlayer(!firstPlayerNowIsMove);

                playerEntry = playerThatNowIsMove.GetCellPositionDecision(gridCells, opponent.GameMark);
            }
            else 
            {
                playerEntry = playerThatNowIsMove.GetCellPositionDecision();
            }

            UserErrors.UserError error;
            Slave.EntryCorrectnessChecker entryCorrectnessChecker = new Slave.EntryCorrectnessChecker();
            error = entryCorrectnessChecker.ItCorrectCellPosition(playerEntry, gridCells);

            if (error.GetType() != new UserErrors.Null().GetType())
            {
                if (playerThatNowIsMove.IAmComputer == false)
                {
                    Slave.UserErrorWriter userErrorWriter = new Slave.UserErrorWriter();
                    userErrorWriter.Write(error.ErrorText);
                }

                Main();
            }

            Slave.EntryParser entryParser = new Slave.EntryParser();
            Keeper.Grid.ChangeCell(entryParser.ParseCellPosition(playerEntry), playerThatNowIsMove.GameMark);

            WhatStageNow whatStageNow = new WhatStageNow();
            whatStageNow.Main();
        }
    }
}
