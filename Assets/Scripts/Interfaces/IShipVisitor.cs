namespace Asteroids.Interfaces
{
    internal interface IShipVisitor
    {
        void Visit(Enemy enemy);
    }
}
