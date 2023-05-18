using UnityEngine;
using Asteroids.ServiceLocator;

namespace Asteroids
{
    internal sealed class GameStarter : MonoBehaviour
    {
        private void Start()
        {
            EnemyPool.EnemyPool enemyPool = new EnemyPool.EnemyPool(5);
            Enemy enemyService = ServiceLocatorMonoBehaviour.GetService<Enemy>();
            var asteroid = enemyPool.GetEnemy("Asteroid");
            asteroid.transform.position = Vector3.one;
            asteroid.gameObject.SetActive(true);

            var enemyShip = enemyPool.GetEnemy("EnemyShip_Type1");
            enemyShip.transform.position = Vector3.one;
            enemyShip.gameObject.SetActive(true);
        }
    }
}
