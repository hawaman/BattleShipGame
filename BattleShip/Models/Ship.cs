using System;
using BattleShipGame.Enums;
namespace BattleShipGame.Models
{
    public abstract class Ship
    {
        public ShipType ShipType { get; set; }
        public int Size { get; set; }

    }
}
