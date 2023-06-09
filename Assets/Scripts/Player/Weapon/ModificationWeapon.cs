﻿using Asteroids.Interfaces;

namespace Asteroids
{
    internal abstract class ModificationWeapon : IFire
    {
        private Weapon _weapon;
        protected abstract Weapon AddModification(Weapon weapon);

        public void ApplyModification(Weapon weapon)
        {
            _weapon = AddModification(weapon);
        }

        public void Fire()
        {
            _weapon.Fire();
        }
    }
}
