namespace Asteroids.Interfaces
{
    internal interface IPlayer
    {
        void Accept(IShipVisitor visitor);
    }
}
