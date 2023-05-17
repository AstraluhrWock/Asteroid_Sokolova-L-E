using UnityEngine;

namespace Asteroids
{
    internal class EnemyMovement 
    {
        private readonly Player _player;
        private readonly Enemy _enemy;
        private readonly float _speed = 2.0f;

        public EnemyMovement(Player player, Enemy enemy)
        {
            _player = player;
            _enemy = enemy;
        }

        public void Execute()
        {
            Vector2 direction = (_player.transform.position - _enemy.transform.position).normalized;
            _enemy.transform.Translate(direction * _speed * Time.deltaTime);
        }
    }
}
