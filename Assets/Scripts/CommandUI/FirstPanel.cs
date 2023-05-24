using UnityEngine;
using TMPro;

namespace Asteroids.Command
{
    internal sealed class FirstPanel : BaseUI
    {
        [SerializeField] private TMP_Text _text;

        public override void Execute()
        {
            _text.text = nameof(FirstPanel);
            gameObject.SetActive(true);
        }

        public override void Cancel()
        {
            gameObject.SetActive(false);
        }
    }
}
