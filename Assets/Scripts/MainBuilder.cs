using UnityEngine;

namespace Asteroids.Builder
{
    internal sealed class MainBuilder : MonoBehaviour
    {
        [SerializeField] private Sprite _sprite;

        private void Start()
        {
            var gameObjectBuilder = new GameObjectBuilder();
            GameObject missile = gameObjectBuilder.Visual.Name("Missile").Sprite(_sprite).Physics.Rigidbody2D(5).BoxCollider2D();
        }
    }
}
