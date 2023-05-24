using System;
using TMPro;
using UnityEngine;

namespace Asteroids.Interpreter
{
   internal sealed class MainInterpreter : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        [SerializeField] private TMP_InputField _inputField;

        private void Start()
        {
            _inputField.onValueChanged.AddListener(Interpreter);
        }

        private void Interpreter(string value)
        {
            if (Int64.TryParse(value, out var number))
            {
                _text.text = ToShot(number);
            }
        }

        private string ToShot(long number)
        {
            if ((number > 0) && (number < 1000)) return number.ToString();
            if ((number >= 1000) && (number <= 999999)) return (number / 1000).ToString() + "K";
            if (number >= 1000000) return (number / 1000000).ToString() + "M";
            throw new ArgumentOutOfRangeException(nameof(number));
        }
    }
}
