using Asteroids.Interfaces;

namespace Asteroids.ParsingFromFile
{
    internal sealed class UnitFactory : IUnitFactory
    {
        private ScoutFactory _scoutFactory;
        private ArmoredFactory _armoredFactory;

        public UnitFactory()
        {
            _scoutFactory = new ScoutFactory();
            _armoredFactory = new ArmoredFactory();
        }

        public Unit CreateUnit(UnitData unitData)
        {
            if (unitData != null && unitData.unit != null)
            {
                if (unitData.unit.type == "scout")
                {
                    return _scoutFactory.CreateUnit(unitData);
                }

                else if (unitData.unit.type == "armored")
                {
                    return _armoredFactory.CreateUnit(unitData);
                }
            }
            return null;
        }
    }
}
