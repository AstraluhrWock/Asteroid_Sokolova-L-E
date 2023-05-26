using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids
{
    public class Bullet : IAmmunition
    {
       
        [SerializeField] 

        public Rigidbody2D BulletInstance { get; }
        public float TimeToDestroy { get; }

        public Bullet(Rigidbody2D bulletInstance, float timeToDestroy)
        {
            BulletInstance = bulletInstance;
            TimeToDestroy = timeToDestroy;
        }
    }
}
