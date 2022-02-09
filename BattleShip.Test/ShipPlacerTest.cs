using System;
using BattleShipGame.Enums;
using BattleShipGame.Implementation;
using Xunit;

namespace BattleShip.Test
{
    public class ShipPlacerTest
    {
        [Theory]
        [InlineData(10, 10, 0, 0, ShipType.Carrier)]
        [InlineData(10, 10, 0, 1, ShipType.Submarine)]
        [InlineData(10, 10, 0, 2, ShipType.Submarine)]
        [InlineData(10, 10, 0, 3, ShipType.Submarine)]
        public void shouldPlaceShipWhenCorrectPositionProvided(
            int boardRows,
            int boardColumns,
            int placementRow,
            int placementColumn,
            ShipType shipType)
        {
            // arrage
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(boardRows, boardColumns);


            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(shipType);

            // act
            var shipPlacer = new ShipPlacer();
            shipPlacer.AddShipToBoard(ship, board, placementRow, placementColumn);
            //assert
            Assert.True(board.BoardCellStatuses[placementRow, placementColumn] == BoardCellStatus.Occupied &&
                board.BoardCellStatuses[placementRow, placementColumn + ship.Size -1] == BoardCellStatus.Occupied);
        }
    }
}
