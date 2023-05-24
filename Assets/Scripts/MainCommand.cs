using UnityEngine;
using System.Collections.Generic;

namespace Asteroids.Command
{
    internal sealed class MainCommand : MonoBehaviour
    {
        [SerializeField] private FirstPanel _firstPanel;
        [SerializeField] private SecondPanel _secondPanel;
        private readonly Stack<StateUI> _stateUIs = new Stack<StateUI>();
        private BaseUI _currentWindow;

        private void Start()
        {
            _firstPanel.Cancel();
            _secondPanel.Cancel();
        }

        private void Execute(StateUI stateUI, bool isSave = true)
        {
            if (_currentWindow != null)
            {
                _currentWindow.Cancel();
            }

            switch (stateUI)
            {
                case StateUI.FirstPanel:
                    _currentWindow = _firstPanel;
                    break;

                case StateUI.SecondPanel:
                    _currentWindow = _secondPanel;
                    break;

                default:
                    break;
            }

            _currentWindow.Execute();
            if (isSave)
            {
                _stateUIs.Push(stateUI);
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Execute(StateUI.FirstPanel);
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Execute(StateUI.SecondPanel);
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (_stateUIs.Count > 0)
                {
                    Execute(_stateUIs.Pop(), false);
                }
            }
        }
    }
}
