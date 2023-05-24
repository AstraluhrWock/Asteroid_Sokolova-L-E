using UnityEngine;

namespace Asteroids
{
    internal sealed class MainDecorator : MonoBehaviour
    {
        private IFire _fire;
        [Header("Start Gun")]
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private Transform _barrelPosition;

        [Header("Muffler Gun")]
        [SerializeField] private float _volumeFireOnMuffler;
        [SerializeField] private Transform _barrelPositionMuffler;
        [SerializeField] private GameObject _muffler;

        [Header("Aim Gun")]
        [SerializeField] private Transform _aimPosition;
        [SerializeField] private GameObject _aim;

        private void Start()
        {
            IAmmunition bullets = new Bullet(_bullet, 10.0f);
            var weapon = new Weapon(bullets, _barrelPosition,  999.0f);
            var muffler = new Muffler(_volumeFireOnMuffler, _barrelPosition, _muffler);
            var aim = new Aim(_aimPosition, _aim);
            ModificationWeapon modificationWeaponMuffler = new ModificationMuffler(muffler, _barrelPositionMuffler.position);
            modificationWeaponMuffler.ApplyModification(weapon);
            ModificationWeapon modificationWeaponAim = new ModificationAim(aim, _aimPosition.position);
            modificationWeaponAim.ApplyModification(weapon);
            _fire = modificationWeaponMuffler;
            _fire = modificationWeaponAim;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _fire.Fire();
            }
        }

    }
}
