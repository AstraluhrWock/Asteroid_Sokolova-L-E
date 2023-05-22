using UnityEngine;

namespace Asteroids
{
    internal interface IAim
    {
        Transform BarrelPositionAim { get; }
        GameObject AimInstance { get; }
    }
}
