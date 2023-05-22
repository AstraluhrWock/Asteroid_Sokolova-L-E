using UnityEngine;

namespace Asteroids
{
    internal interface IAmmunition
    {
        Rigidbody2D BulletInstance { get; }
        float TimeToDestroy { get; }
    }
}