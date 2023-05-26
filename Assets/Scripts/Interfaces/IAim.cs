using UnityEngine;

namespace Asteroids.Interfaces
{
    internal interface IAim
    {
        Transform BarrelPositionAim { get; }
        GameObject AimInstance { get; }
    }
}
