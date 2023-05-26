using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids
{
    internal sealed class Muffler : IMuffler
    {
        public float VolumeFireOnMuffler { get; }
        public Transform BarrelPositionMuffler { get; }
        public GameObject MufflerInstance { get; }
        public Muffler(float volumeFireOnMuffler, Transform barrelPositionMuffler, GameObject mufflerInstance)
        {
            VolumeFireOnMuffler = volumeFireOnMuffler;
            BarrelPositionMuffler = barrelPositionMuffler;
            MufflerInstance = mufflerInstance;
        }
    }
}