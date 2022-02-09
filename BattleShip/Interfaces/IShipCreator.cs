using System;
using BattleShipGame.Models;
using BattleShipGame.Enums;
namespace BattleShipGame.Interfaces
{
    public interface IShipCreator
    {
        Ship CreateShip(ShipType shipType);
    }
}
