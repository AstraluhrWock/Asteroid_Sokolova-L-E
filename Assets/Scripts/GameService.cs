using Asteroids.Interfaces;

namespace Asteroids
{
    internal sealed class GameService
    {
        public void Start(IAttack attack)
        {
            var player = CreatePlayer(attack);
            var asteroid = CreateAsteroid();
        }

        private Player CreatePlayer(IAttack attack)
        {
            return new Player(attack);
        }

        private Enemy CreateAsteroid()
        {
            return new Asteroid();
        }

    }
}
