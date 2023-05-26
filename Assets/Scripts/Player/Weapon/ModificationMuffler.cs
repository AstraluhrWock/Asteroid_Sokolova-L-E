using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids
{
    internal sealed class ModificationMuffler : ModificationWeapon
    {
        private readonly IMuffler _muffler;
        private readonly Vector3 _mufflerPosition;

        public ModificationMuffler(IMuffler muffler, Vector3 mufflerPosition)
        {
            _muffler = muffler;
            _mufflerPosition = mufflerPosition;
        }
        protected override Weapon AddModification(Weapon weapon)
        {
            var muffler = Object.Instantiate(_muffler.MufflerInstance, _mufflerPosition, Quaternion.identity);
            weapon.SetBarrelPosition(_muffler.BarrelPositionMuffler);
            return weapon;
        }
    }
}