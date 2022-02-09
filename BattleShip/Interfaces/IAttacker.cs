using System;
using BattleShipGame.Models;
using BattleShipGame.Enums;
namespace BattleShipGame.Interfaces
{
    public interface IAttacker
    {
        AttackStatus Attack(Board board, int row, int column);
    }
}
