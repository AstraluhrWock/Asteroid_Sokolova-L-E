namespace Asteroids.Interfaces
{
    internal interface IEnemyFactory
    {
        Enemy Create(Health hp);
    }
}
