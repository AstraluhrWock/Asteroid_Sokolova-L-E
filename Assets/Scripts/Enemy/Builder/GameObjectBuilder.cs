using UnityEngine;

namespace Asteroids.Builder
{
    internal class GameObjectBuilder : MonoBehaviour
    {
        protected GameObject _gameObject;

        public GameObjectBuilder() => _gameObject = new GameObject();
        protected GameObjectBuilder(GameObject gameObject) => _gameObject = gameObject;

        public GameObjectVisualBuilder Visual => new GameObjectVisualBuilder(gameObject);
        
    }
}
