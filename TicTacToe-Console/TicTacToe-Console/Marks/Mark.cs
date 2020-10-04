using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TicTacToe_Console.Marks
{
    abstract class Mark
    {
        public char Sign { get; protected set; }

        private Color currentColor = Color.LightGray;

        public readonly Color WonColor = Color.White;

        public Color GetCurrentColor()
        {
            return currentColor;
        }

        public void Won()
        {
            currentColor = WonColor;
        }
    }
}
