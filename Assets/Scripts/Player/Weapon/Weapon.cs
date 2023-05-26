using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids
{
    internal class Weapon : IFire, IWeapon
    {
        private Transform _barrelPosition;
        private IAmmunition _bullet;
        private float _force;

        public Weapon(IAmmunition bullet, Transform barrelPosition, float force)
        {
            _bullet = bullet;
            _barrelPosition = barrelPosition;
            _force = force;
        }

        public void SetBarrelPosition(Transform barrelPosition)
        {
            _barrelPosition = barrelPosition;
        }

        public void SetBullet(IAmmunition bullet)
        {
            _bullet = bullet;
        }

        public void SetForce(float force)
        {
            _force = force;
        }

        public void Fire()
        {
            var bullet = Object.Instantiate(_bullet.BulletInstance, _barrelPosition.position, Quaternion.identity);
            bullet.AddForce(_barrelPosition.up * _force);
            Object.Destroy(bullet.gameObject, _bullet.TimeToDestroy);
        }
    }
}
