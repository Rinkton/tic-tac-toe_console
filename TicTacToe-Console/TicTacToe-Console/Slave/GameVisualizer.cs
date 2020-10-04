using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;
using Colorful;

namespace TicTacToe_Console.Slave
{
    class GameVisualizer
    {
        public void VisualizeGame(Marks.Mark[,] cells, string currentStageDefinition)
        {
            Console.Clear();

            visualizeGrid(cells);
            visualizeCurrentStageDefinition(currentStageDefinition);
        }

        private void visualizeGrid(Marks.Mark[,] cells)
        {
            string grid = " 1 2 3" + Environment.NewLine +
                          "1{0}|{1}|{2}" + Environment.NewLine +
                          " -+-+-" + Environment.NewLine +
                          "2{3}|{4}|{5}" + Environment.NewLine +
                          " -+-+-" + Environment.NewLine +
                          "3{6}|{7}|{8}";

            //It give to marks in cells individual colors
            //(It need to highlight marks if it's won marks)
            Formatter[] coloredCells = new Formatter[]
            {
                new Formatter(cells[0,0].Sign, cells[0,0].GetCurrentColor()),
                new Formatter(cells[1,0].Sign, cells[1,0].GetCurrentColor()),
                new Formatter(cells[2,0].Sign, cells[2,0].GetCurrentColor()),
                new Formatter(cells[0,1].Sign, cells[0,1].GetCurrentColor()),
                new Formatter(cells[1,1].Sign, cells[1,1].GetCurrentColor()),
                new Formatter(cells[2,1].Sign, cells[2,1].GetCurrentColor()),
                new Formatter(cells[0,2].Sign, cells[0,2].GetCurrentColor()),
                new Formatter(cells[1,2].Sign, cells[1,2].GetCurrentColor()),
                new Formatter(cells[2,2].Sign, cells[2,2].GetCurrentColor()),
            };

            Console.WriteLineFormatted(grid, Color.LightGray, coloredCells);
        }

        private void visualizeCurrentStageDefinition(string currentStageDefinition)
        {
            ConsoleExt.Visualize(currentStageDefinition);
        }
    }
}
