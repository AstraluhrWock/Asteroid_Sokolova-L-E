using UnityEngine;
using Asteroids.Interfaces;

namespace Asteroids.Visitor
{
    internal sealed class MainVisitor: MonoBehaviour
    {
        private void Start()
        {
            Enemy asteroid = new Asteroid();
            Enemy enemyShip = new EnemyShip();

            IShipVisitor visitor = new LoggerVisitor();

            asteroid.Accept(visitor);
            enemyShip.Accept(visitor);
        }
    }
}
