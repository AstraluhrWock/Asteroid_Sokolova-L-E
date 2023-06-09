﻿using System;

namespace Asteroids.Prototype
{
    [Serializable]
    internal sealed class EnemyHP
    {
        public float MaxHP;
        public float CurrentHP;

        public override string ToString()
        {
            return $"MaxHP {MaxHP} CurrentHP {CurrentHP}";
        }
    }
}
