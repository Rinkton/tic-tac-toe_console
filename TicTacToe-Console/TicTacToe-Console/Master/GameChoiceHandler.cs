using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Master
{
    class GameChoiceHandler : Other.Master
    {
        public void Main()
        {
            Keeper.Stage stageKeeper = new Keeper.Stage();
            Slave.Stages.Stage currentStage = stageKeeper.GetCurrentStage();
            bool firstPlayerNowIsMove = currentStage == new Slave.Stages.FirstPlayerMove();

            Keeper.Players playersKeeper = new Keeper.Players();
            Slave.Players.Player playerThatNowIsMove = playersKeeper.GetPlayer(firstPlayerNowIsMove);

            string playerEntry;

            Keeper.Grid gridKeeper = new Keeper.Grid();

            if (playerThatNowIsMove.IAmBot == true)
                playerEntry = playerThatNowIsMove.GetCellPositionDecision(gridKeeper.GetCells());
            else
                playerEntry = playerThatNowIsMove.GetCellPositionDecision();

            bool isCorrectCellPositionEntry;
            int gridSize = gridKeeper.GetGridSize();
            Slave.EntryCorrectnessChecker entryCorrectnessChecker = new Slave.EntryCorrectnessChecker();
            isCorrectCellPositionEntry = entryCorrectnessChecker.ItCorrectCellPosition(playerEntry, gridSize);

            if (!isCorrectCellPositionEntry && playerThatNowIsMove.IAmBot == false)
            {
                Slave.UserErrors.UserError incorrectCellPositionEntry;
                incorrectCellPositionEntry = new Slave.UserErrors.IncorrectCellPositionEntry();

                Slave.UserErrorWriter userErrorWriter = new Slave.UserErrorWriter();
                userErrorWriter.Write(incorrectCellPositionEntry.GetErrorText());

                Main();
            }
            else if (!isCorrectCellPositionEntry && playerThatNowIsMove.IAmBot == true)
            {
                Main();
            }

            Slave.EntryParser entryParser = new Slave.EntryParser();
            gridKeeper.ChangeCell(entryParser.ParseCellPosition(playerEntry), playerThatNowIsMove.Mark);

            WhatStageNow whatStageNow = new WhatStageNow();
            whatStageNow.Main();
        }
    }
}
