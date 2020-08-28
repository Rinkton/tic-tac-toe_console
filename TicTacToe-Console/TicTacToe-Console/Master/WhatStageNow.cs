using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Master
{
    class WhatStageNow : Other.Master
    {
        public void Main()
        {
            Keeper.Grid gridKeeper = new Keeper.Grid();

            Slave.GridAnalyzer gridAnalyzer = new Slave.GridAnalyzer();
            bool isVictory = gridAnalyzer.ItVictory(gridKeeper.GetCells());
            bool isDraw = gridAnalyzer.ItDraw(gridKeeper.GetCells());

            Keeper.Stage stageKeeper = new Keeper.Stage();

            if (isVictory)
            {
                stageKeeper.Victory();

                HighlightWonCells highlightWonCells = new HighlightWonCells();
                highlightWonCells.Main();
            }  
            else if (isDraw)
            {
                stageKeeper.Draw();
            } 
            else
            {
                stageKeeper.NextPlayerMove();
            }

            GameVisualizer gameVisualizer = new GameVisualizer();
            gameVisualizer.Main();
        }
    }
}
