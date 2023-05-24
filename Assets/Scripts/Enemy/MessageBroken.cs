using System;

namespace Asteroids
{
    internal sealed class MessageBroken
    {
        public delegate void EnemyDestroyedEventHandler(string enemyName);
        public static event EnemyDestroyedEventHandler EnemyDestroyerEvent;

        public static void SubscribeDestroyMessage(string enemyName)
        {
            EnemyDestroyerEvent?.Invoke(enemyName);
        }
    }
}
