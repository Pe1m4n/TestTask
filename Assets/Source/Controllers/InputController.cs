using System.Collections.Generic;
using UnityEngine;

namespace Controllers
{
    public class InputController : IInputController
    {
        private readonly List<KeyCode> _pressedKeys = new List<KeyCode>();

        private readonly List<KeyCode> _keysToCheck = new List<KeyCode>()
        {
            KeyCode.Mouse0,
            KeyCode.Mouse1
        };
        
        public void CollectInputs()
        {
            foreach (var keyCode in _keysToCheck)
            {
                if (Input.GetKeyDown(keyCode))
                {
                    _pressedKeys.Add(keyCode);
                }
            }
        }

        public IReadOnlyList<KeyCode> GetCurrentKeys()
        {
            return _pressedKeys;
        }

        public Vector3 GetMousePosition()
        {
            return Input.mousePosition;
        }

        public void ClearInputs()
        {
            _pressedKeys.Clear();
        }
    }
}