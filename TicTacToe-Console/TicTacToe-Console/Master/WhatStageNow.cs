using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Master
{
    class WhatStageNow : IMaster
    {
        public void Main()
        {
            Slave.GridAnalyzer gridAnalyzer = new Slave.GridAnalyzer();
            bool isVictory = gridAnalyzer.ItVictory(Keeper.Grid.GetCells());
            bool isDraw = gridAnalyzer.ItDraw(Keeper.Grid.GetCells());

            if (isVictory)
            {
                Keeper.Stage.SetVictory();

                HighlightWonCells highlightWonCells = new HighlightWonCells();
                highlightWonCells.Main();
            }  
            else if (isDraw)
            {
                Keeper.Stage.SetDraw();
            } 
            else
            {
                Keeper.Stage.SetNextPlayerIsMove();
            }

            GameVisualizer gameVisualizer = new GameVisualizer();
            gameVisualizer.Main();
        }
    }
}
