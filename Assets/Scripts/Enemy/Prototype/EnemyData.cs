using System;

namespace Asteroids.Prototype
{
    [Serializable]
    internal sealed class EnemyData
    {
        public float Speed;
        public EnemyHP hp;

        public override string ToString()
        {
            return $"Speed {Speed} HP {hp}";
        }
    }
}
