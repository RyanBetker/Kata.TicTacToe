using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Specs
{
    /// <summary>
    /// Turn was tried in a spot already taken
    /// </summary>
    public class PositionTakenException : Exception
    {
        public PositionTakenException()
        {

        }
    }
}
