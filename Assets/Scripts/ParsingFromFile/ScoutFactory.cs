using Asteroids.Interfaces;

namespace Asteroids.ParsingFromFile
{
    internal class ScoutFactory : IUnitFactory
    {
        public Unit CreateUnit(UnitData unitData)
        {
            ScoutUnit scoutUnit = new ScoutUnit();
            scoutUnit.Type = unitData.unit.type;
            scoutUnit.Health = unitData.unit.health;
            return scoutUnit;
        }
    }
}
