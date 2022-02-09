using System;
using BattleShipGame.Enums;
using BattleShipGame.Implementation;
using Xunit;
namespace BattleShip.Test
{
    public class AttacketTest
    {
        [Theory]
        [InlineData(10, 10, 0, 0, 0, 0, ShipType.Submarine, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 1, ShipType.Submarine, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 2, ShipType.Submarine, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 0, 3, ShipType.Submarine, BoardCellStatus.Miss)

        public void shouldReturnCorrectAttackStatusWhenAttacked(
            int boardRows,
            int boardColumns,
            int placementRow,
            int placementColumn,
            int attackRow,
            int attackColumn,
            ShipType shipType, BoardCellStatus boardCellStatus)
        {
            // arrage
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(boardRows, boardColumns);


            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(shipType);

            var shipPlacer = new ShipPlacer();
            shipPlacer.AddShipToBoard(ship, board, placementRow, placementColumn);


            // act

            var attacker = new Attacker();
            var result = attacker.Attack(board, attackRow, attackColumn);
            //assert
            Assert.True(board.BoardCellStatuses[attackRow, attackColumn] == boardCellStatus);
        }
      
    }
}
