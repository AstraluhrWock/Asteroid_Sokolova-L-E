using UnityEngine;

namespace Asteroids.Interfaces
{
    internal interface IMuffler
    {
        float VolumeFireOnMuffler { get; }
        Transform BarrelPositionMuffler { get; }
        GameObject MufflerInstance { get; }
    }
}
