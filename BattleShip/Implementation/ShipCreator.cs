using System;
using BattleShipGame.Enums;
using BattleShipGame.Interfaces;
using BattleShipGame.Models;
using BattleShipGame.Models.Ships;

namespace BattleShipGame.Implementation
{
    public class ShipCreator : IShipCreator
    {
        public Ship CreateShip(ShipType shipType)
        {
            try
            {
                switch (shipType)
                {
                    case ShipType.Carrier:
                        return new Carrier();
                    case ShipType.Submarine:
                        return new Submarine();
                    default:
                        return new Carrier();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ship creation failed:{ex.Message}");
            }
        }
    }
}
