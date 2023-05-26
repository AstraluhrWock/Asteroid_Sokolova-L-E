using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids
{
    internal sealed class MainProxy : MonoBehaviour
    {
        [SerializeField] private Transform _barrelPosition;
        [SerializeField] private IAmmunition _bullet;
        [SerializeField] private float _force;
        private void Start()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var unlockWeapon = new UnlockWeapon(false);
                var weapon = new Weapon(_bullet, _barrelPosition, _force);
                var weaponProxy = new WeaponProxy(weapon, unlockWeapon);
                weaponProxy.Fire();
                unlockWeapon.IsUnlock = true;
                weaponProxy.Fire();
            }
        }
    }
}
