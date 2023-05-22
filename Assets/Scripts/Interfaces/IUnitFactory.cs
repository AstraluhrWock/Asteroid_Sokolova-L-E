using Asteroids.ParsingFromFile;

namespace Asteroids.Interfaces
{
    internal interface IUnitFactory 
    {
        Unit CreateUnit(UnitData unitData);
    }
}
