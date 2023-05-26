using Asteroids.Interfaces;
using UnityEngine;
using System;

namespace Asteroids
{
    internal abstract class Enemy : MonoBehaviour, IHit, IPlayer
    {
        private Transform _rootPool;
        private Health _health;
        private EnemyMovement _enemyMovement;

        public static IEnemyFactory Factory;
        public event Action<float> OnHitChange = delegate (float hit) { };

        public string Name { get; }

        public Health Health
        {
            get
            {
                if (_health.Current <= 0.0f)
                {
                    MessageBroken.SubscribeDestroyMessage(gameObject.name);
                }
                return _health;
            }
            protected set => _health = value; 
        
        }

        public void Hit(float damage)
        {
            OnHitChange.Invoke(damage);
        }

        public void Accept(IShipVisitor visitor)
        {
            visitor.Visit(this);
        }

        private void Start()
        {
            _enemyMovement = new EnemyMovement(this);
        }

        private void Update()
        {
            _enemyMovement.Execute();
        }

        private void OnEnable()
        {
            MessageBroken.EnemyDestroyerEvent += HandlerEnemyDestroyer;
        }

        private void OnDisable()
        {
            MessageBroken.EnemyDestroyerEvent -= HandlerEnemyDestroyer;
        }

        private void HandlerEnemyDestroyer(string enemyName)
        {
            Debug.Log($"Enemy {enemyName} has been destroyed");
        }
    }
}
