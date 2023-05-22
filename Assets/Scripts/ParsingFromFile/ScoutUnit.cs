using UnityEngine;

namespace Asteroids.ParsingFromFile
{
    internal sealed class ScoutUnit : Unit
    {
        private bool _IsVisible;
        private float _health;
        private string _type;

        public bool IsVisible
        {
            get { return _IsVisible; }
            set { _IsVisible = value; }
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
