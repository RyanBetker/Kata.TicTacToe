using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Specs
{
    public enum PlayerType
    {
        X, O
    }

    public class Game
    {
        PlayerType? previousPlayer;

        public Game()
        {
            Board = new PlayerType?[3, 3];
        }

        /// <summary>
        /// Plays a turn
        /// </summary>
        /// <param name="playerType">Player type</param>
        /// <param name="row">Row in which to play. Use 0-2</param>
        /// <param name="column">Column in which to play. Use 0-2</param>
        public void PlayTurn(PlayerType playerType, int row, int column)
        {
            ValidateTurn(playerType, row, column);

            Board[row, column] = playerType;
            previousPlayer = playerType;
            return;
        }

        private void ValidateTurn(PlayerType playerType, int row, int column)
        {
            if (row > 2 || row < 0)
            {
                throw new ArgumentException("Row value must be between 0 and 2");
            }

            if (column > 2 || column < 0)
            {
                throw new ArgumentException("Column value must be between 0 and 2");
            }

            //Protect against position already taken
            if (Board[row, column] != null)
            {
                throw new PositionTakenException();
            }

            //Protect against double plays
            if (previousPlayer != null && previousPlayer == playerType)
            {
                throw new DoublePlayException();
            }
        }

        /// <summary>
        /// First position is for rows, second is columns
        /// </summary>
        public PlayerType?[,] Board { get; private set; }
    }
}
