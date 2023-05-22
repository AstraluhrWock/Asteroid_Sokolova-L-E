using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids
{
    internal sealed class MainFacade : MonoBehaviour
    {
        [SerializeField] private IAttack _attack;

        private void Start()
        {
            var gameService = new GameService();
            gameService.Start(_attack);
        }
    }
}
