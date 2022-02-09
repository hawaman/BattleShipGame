using System;
namespace BattleShipGame.Models.Ships
{
    public class Submarine: Ship
    {
        public Submarine()
        {
            Size = 2;
            ShipType = Enums.ShipType.Submarine;
        }
    }
}
