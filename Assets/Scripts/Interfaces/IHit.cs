using System;

namespace Asteroids.Interfaces
{
    public interface IHit
    {
        event Action<float> OnHitChange;
        void Hit(float damage);
    }
}
