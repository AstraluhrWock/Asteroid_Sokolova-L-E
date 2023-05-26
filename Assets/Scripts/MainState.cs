using UnityEngine;

namespace Asteroids.StatePattent
{
    internal sealed class MainState : MonoBehaviour
    {
        private void Start()
        {
            State state = new State();

            state.Move();
            state.Move();
            state.Stop();
            state.Stop();
        }
    }
}
