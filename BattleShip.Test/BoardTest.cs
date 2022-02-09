using System;
using BattleShipGame.Enums;
using BattleShipGame.Implementation;
using Xunit;

namespace BattleShip.Test
{
    public class BoardTest
    {
        [Theory]
        [InlineData(10, 10)]
        [InlineData(20, 20)]
        [InlineData(30, 30)]
        [InlineData(40, 40)]
        public void shouldReturnValidBoardWhenBoardCreated(
             int boardRows,
             int boardColumns)
        {
            // arrage
            var boardCreator = new BoardCreator();

            //action
            var board = boardCreator.CreateBoard(boardRows, boardColumns);

            //assert
            Assert.Equal(boardRows * boardColumns,board.BoardCellStatuses.Length);
        }
    }
}
