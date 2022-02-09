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
            // lets make the boardcellstatus ocupied for those cells that ship occupies
            for (int i = 0; i < ship.Size; i++)
            {
                board.BoardCellStatuses[row, column+i] = BoardCellStatus.Occupied;
                board.OccupationCount++;
            }
        }
       
    }
}
