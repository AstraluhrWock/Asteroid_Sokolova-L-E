using UnityEngine;
using Asteroids.Interfaces;

namespace Asteroids.StatePattent
{
    internal sealed class State
    {
        private IState _currnetState;

        public State()
        {
            _currnetState = new IdleState();
        }

        public void SetState(IState state)
        {
            _currnetState = state;
        }

        public void Move()
        {
            _currnetState.Move(this);
        }

        public void Stop()
        {
            _currnetState.Stop(this);
        }
    }
}
