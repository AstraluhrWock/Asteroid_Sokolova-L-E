using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids.Visitor
{
    internal sealed class LoggerVisitor : IShipVisitor
    {
        public void Visit(Enemy enemy)
        {
            Debug.Log($"Enemy appeared: {enemy.GetType().Name}");
        }
    }
}
