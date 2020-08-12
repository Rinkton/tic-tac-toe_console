using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console.Objects.Stages
{
    /// <summary>
    /// Abstract class of stage on move of the game.
    /// </summary>
    abstract class Stage
    {
        /// <summary>
        /// Description of stage, which displaying on move.
        /// </summary>
        protected string description;

        /// <summary>
        /// Return description of stage.
        /// </summary>
        /// <returns>Description of stage.</returns>
        public string GetStageDescription()
        {
            return description;
        }

        /// <summary>
        /// What happening if this stage now.
        /// </summary>
        public abstract void Execute();
    }
}
