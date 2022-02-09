using System;
using BattleShipGame.Models;
namespace BattleShipGame.Interfaces
{
    public interface IBoardCreator
    {
        Board CreateBoard(int rows, int columns);
    }
}
