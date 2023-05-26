using UnityEngine;

namespace Asteroids.Interfaces
{
    internal interface IAmmunition
    {
        Rigidbody2D BulletInstance { get; }
        float TimeToDestroy { get; }
    }
}