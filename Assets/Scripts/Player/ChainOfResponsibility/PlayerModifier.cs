using UnityEngine;

namespace Asteroids
{
    internal class PlayerModifier
    {
        protected Player _player;
        protected PlayerModifier Next;

        public PlayerModifier(Player player)
        {
            _player = player;
        }

        public void Add(PlayerModifier modifier)
        {
            if (Next != null)
            {
                Next.Add(modifier);
            }
            else 
            {
                Next = modifier;
            }
        }

        public virtual void Handler() => Next?.Handler();
    }
}
