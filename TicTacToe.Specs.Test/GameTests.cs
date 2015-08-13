using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicTacToe.Specs.Test
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void GameStoresPositionTopLeft()
        {
            var g = new Game();
            var playerType = PlayerType.X;

            g.PlayTurn(playerType, 0, 0);

            Assert.AreEqual(playerType, g.Board[0, 0]);
        }

        [TestMethod]
        public void GameStoresPositionTopMiddle()
        {
            var g = new Game();
            var playerType = PlayerType.X;

            g.PlayTurn(playerType, 0, 1);

            Assert.AreEqual(playerType, g.Board[0, 1]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GameDoesNotAllowRowUnder0()
        {
            var g = new Game();
            var playerType = PlayerType.X;

            g.PlayTurn(playerType, -1, 1);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GameDoesNotAllowColumnUnder0()
        {
            var g = new Game();
            var playerType = PlayerType.X;

            g.PlayTurn(playerType, -1, 0);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GameDoesNotAllowRowOver2()
        {
            var g = new Game();
            var playerType = PlayerType.X;

            g.PlayTurn(playerType, 3, 1);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GameDoesNotAllowColumnOver2()
        {
            var g = new Game();
            var playerType = PlayerType.X;

            g.PlayTurn(playerType, 2, 3);

        }
        [TestMethod]
        [ExpectedException(typeof(PositionTakenException))]
        public void GameDoesNotAllowRepeatedPlayInPosition()
        {
            var g = new Game();
            var playerType = PlayerType.X;

            g.PlayTurn(playerType, 2, 2);
            g.PlayTurn(PlayerType.O, 0, 2);
            
            //Should throw Ex:
            g.PlayTurn(playerType, 2, 2);

        }

        [TestMethod]
        [ExpectedException(typeof(DoublePlayException))]
        public void GameDoesNotAllowDoublePlayInPosition()
        {
            var g = new Game();
            var playerType = PlayerType.X;

            g.PlayTurn(playerType, 2, 2);

            //Should throw Ex:
            g.PlayTurn(playerType, 2, 2);

        }

        [TestMethod]
        public void GameStoresAccuratePlayer()
        {
            var g = new Game();
            var playerType = PlayerType.O;

            g.PlayTurn(playerType, 0, 0);

            Assert.AreEqual(playerType, g.Board[0, 0]);
        }

        //[TestMethod]
        ////public void GameClaimsWinner()
        //{
        //    var g = new Game();
        //    var playerType = PlayerType.O;

        //    g.PlayTurn(playerType, 0, 0);

        //    Assert.AreEqual(playerType, g.Board[0, 0]);
        //}
    }
}
