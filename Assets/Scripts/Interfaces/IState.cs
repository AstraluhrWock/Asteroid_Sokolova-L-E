using Asteroids.StatePattent;

namespace Asteroids.Interfaces
{
    internal interface IState
    {
        void Move(State state);
        void Stop(State state);
    }
}
