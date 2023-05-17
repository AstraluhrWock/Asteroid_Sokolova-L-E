using Asteroids.EnemyPool;
using UnityEngine;

namespace Asteroids
{
    internal abstract class Enemy : MonoBehaviour
    {
        public static IEnemyFactory Factory;
        private Transform _rootPool;
        private Health _health;
        private Player _player;
        private EnemyMovement _enemyMovement;

        public Health Health
        {
            get
            {
                /*if (_health.Current <= 0.0f)
                {
                    //RemovePool();
                }*/
                return _health;
            }
            protected set => _health = value; 
        
        }

        private void Start()
        {
            _player = FindObjectOfType<Player>();
            _enemyMovement = new EnemyMovement(_player, this);
        }

        private void Update()
        {
            _enemyMovement.Execute();
        }
    }
}
