using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids.StatePattent
{
    internal sealed class MovingState : IState
    {
        public void Move(State state)
        {
            Debug.Log("Ship is alerady moving");
        }

        public void Stop(State state)
        {
            Debug.Log("Ship stops moving");
            state.SetState(new IdleState());
        }
    }
}
