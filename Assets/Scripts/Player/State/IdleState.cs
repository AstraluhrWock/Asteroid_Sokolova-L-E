using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids.StatePattent
{
    internal sealed class IdleState : IState
    {
       public void Move(State state)
        {
            Debug.Log("Ship start moving");
            state.SetState(new MovingState());
        }

        public void Stop(State state)
        {
            Debug.Log("Ship is already stopped");
        }
    }
}
