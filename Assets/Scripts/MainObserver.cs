using UnityEngine;
using Asteroids.Interfaces;

namespace Asteroids
{
    internal sealed class MainObserver : MonoBehaviour
    {
        public Enemy Enemy;
        public float Damage;
        private Camera _camera;
        private float _dictance = 20.0f;

        private void Start()
        {
            _camera = Camera.main;
            ListenerHitShowDamage listenerHit = new ListenerHitShowDamage();
            listenerHit.Add(Enemy);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(_camera.ScreenPointToRay(Input.mousePosition), out var hit, _dictance))
                {
                    if (hit.collider.TryGetComponent<IHit>(out var enemy))
                    {
                        enemy.Hit(Damage);
                    }
                }
            }
        }
    }
}
