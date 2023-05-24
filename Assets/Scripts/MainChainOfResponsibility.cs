using UnityEngine;

namespace Asteroids
{
    internal sealed class MainChainOfResponsibility : MonoBehaviour
    {
        private void Start()
        {
            Player player = new Player(2,5);
            PlayerModifier root = new PlayerModifier(player);
            root.Add(new AddDefenceModifier(player, 2));
            root.Add(new AddPowerModifier(player, 3));
            root.Handler();
        }
    }
}
