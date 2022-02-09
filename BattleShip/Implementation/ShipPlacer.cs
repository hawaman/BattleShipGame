using System;
using BattleShipGame.Interfaces;
using BattleShipGame.Models;
using BattleShipGame.Enums;

namespace BattleShipGame.Implementation
{
    public class ShipPlacer : IShipPlacer
    {
        public void AddShipToBoard(Ship ship, Board board, int row, int column)
        {
            Validate(ship, board, row, column);
            // lets make the boardcellstatus ocupied for those cells that ship occupies
            for (int i = 0; i < ship.Size; i++)
            {
                board.BoardCellStatuses[row, column + i] = BoardCellStatus.Occupied;
                board.OccupationCount++;
            }
        }
        private void Validate(Ship ship, Board board, int row, int column)
        {
            string errorMsg = "Position of ship on the board is out of bound";
            //check if both row column coordinates of is inside the board
            if (row > board.Rows)
            {
                throw new IndexOutOfRangeException(errorMsg);
            }
            else if (column > board.Columns)
            {
                throw new IndexOutOfRangeException(errorMsg);
            }
            //
            for (int s = 0; s < ship.Size; s++)
            {
                if (column + s > board.Columns)
                {
                    throw new Exception(errorMsg);
                }
            }

        }
    }
}
