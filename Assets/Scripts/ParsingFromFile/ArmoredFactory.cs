using Asteroids.Interfaces;

namespace Asteroids.ParsingFromFile
{
    internal class ArmoredFactory : IUnitFactory
    {
        public Unit CreateUnit(UnitData unitData)
        {
            ArmoredUnit armoredUnit = new ArmoredUnit();
            armoredUnit.Type = unitData.unit.type;
            armoredUnit.Health = unitData.unit.health;
            return armoredUnit;
        }
    }
}
