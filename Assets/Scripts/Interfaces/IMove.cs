namespace Asteroids.Interfaces
{
    public interface IMove 
    {
        float Speed { get; }
        void Move(float horizontal, float vertical, float deltaTime);
    }
}
