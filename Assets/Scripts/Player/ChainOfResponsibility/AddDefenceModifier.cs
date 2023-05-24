namespace Asteroids
{
    internal sealed class AddDefenceModifier : PlayerModifier
    {
        private readonly float _maxDefence;

        public AddDefenceModifier(Player player, float defence) : base(player)
        {
            _maxDefence = defence;
        }

        public override void Handler()
        {
            if (_player.Defence <= _maxDefence)
            {
                _player.Defence++;
            }
            base.Handler();
        }
    }
}
