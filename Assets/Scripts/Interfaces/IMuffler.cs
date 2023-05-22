using UnityEngine;

namespace Asteroids
{
    internal interface IMuffler
    {
        float VolumeFireOnMuffler { get; }
        Transform BarrelPositionMuffler { get; }
        GameObject MufflerInstance { get; }
    }
}
