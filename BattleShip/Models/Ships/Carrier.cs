using System;
namespace BattleShipGame.Models.Ships
{
    public class Carrier : Ship
    {
        public Carrier()
        {
            Size = 5;
            ShipType = Enums.ShipType.Carrier;
        }
    }
}
