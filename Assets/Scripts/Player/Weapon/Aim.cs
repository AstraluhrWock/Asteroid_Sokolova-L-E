using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids
{
    internal sealed class Aim : IAim
    {
        public Transform BarrelPositionAim { get; }
        public GameObject AimInstance { get; }

        public Aim(Transform barrelPositionAim, GameObject mufflerInstance)
        {
            BarrelPositionAim = barrelPositionAim;
            AimInstance = mufflerInstance;
        }
    }
}