using Asteroids.Iterator;

namespace Asteroids.Interfaces
{
    internal interface IAbility
    {
        string Name { get; }
        int Damage { get; }
        Target Target { get; }
        DamageType DamageType { get; }
    }
}
