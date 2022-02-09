using System;
using BattleShipGame.Models;
namespace BattleShipGame.Interfaces
{
    public interface IShipPlacer
    {
        void AddShipToBoard(Ship ship, Board board, int row, int column);
    }
}
