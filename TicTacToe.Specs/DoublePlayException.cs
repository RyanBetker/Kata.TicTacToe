using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Specs
{
    /// <summary>
    /// A player attempted to play in a spot already taken
    /// </summary>
    public class DoublePlayException : Exception
    {
        public DoublePlayException()
        {

        }
    }
}
