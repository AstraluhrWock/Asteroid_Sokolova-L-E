using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids
{
    internal sealed class CrossAttack : MonoBehaviour, IAttack
    {
        private Player _player;
        private Crosshair _crosshair;
   
        public void Attack()
        {
            _crosshair.CreateCrosshair();
        }
    }
}
