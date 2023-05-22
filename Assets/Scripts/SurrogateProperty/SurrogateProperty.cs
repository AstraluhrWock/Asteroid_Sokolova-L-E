using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.SurrogateProperty
{
    public class SurrogateProperty : MonoBehaviour
    {
        [SerializeField]
        private List<SerializableKeyValuePair<string, int>> _serializablesDictionary = new List<SerializableKeyValuePair<string, int>>();
        private Dictionary<string, int> _dictionary = new Dictionary<string, int>();

        public Dictionary<string, int> Dictionary
        {
            get { return _dictionary; }
            set { _dictionary = value; }
        }

        private void OnValidate()
        {
            _dictionary.Clear();
            foreach (var kvp in _serializablesDictionary)
            {
                _dictionary[kvp.Key] = kvp.Value;
            }
        }
    }
}
