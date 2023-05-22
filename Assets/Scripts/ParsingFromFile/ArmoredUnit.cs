namespace Asteroids.ParsingFromFile
{
    internal sealed class ArmoredUnit : Unit
    {
        private float _armoredValue;
        private float _health;
        private string _type;

        public float ArmoredValue
        {
            get { return _armoredValue; }
            set { _armoredValue = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public float Health
        {
            get { return _health; }
            set { _health = value; }
        }
    }
}
