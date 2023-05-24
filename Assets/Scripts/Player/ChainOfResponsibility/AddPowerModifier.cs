
namespace Asteroids
{
    internal sealed class AddPowerModifier : PlayerModifier
    {
        private readonly float _power;

        public AddPowerModifier(Player player, float power) : base(player)
        {
            _power = power;
        }

        public override void Handler()
        {
            _player.Power += _power;
            base.Handler();
        }
    }
}
