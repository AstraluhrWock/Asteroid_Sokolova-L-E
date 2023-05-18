using UnityEngine;

namespace Asteroids
{
    internal class EnemyMovement 
    {
        private readonly Enemy _enemy;
        private readonly float _speed = 2.0f;

        public EnemyMovement(Enemy enemy)
        {
           _enemy = enemy;
        }

        public void Execute()
        {
            Vector2 direction = Vector2.down * _speed * Time.deltaTime;
            _enemy.transform.Translate(direction);
        }
    }
}
