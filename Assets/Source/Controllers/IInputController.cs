using System.Collections.Generic;
using UnityEngine;

namespace Controllers
{
    public interface IInputController
    {
        IReadOnlyList<KeyCode> GetCurrentKeys();
        Vector3 GetMousePosition();
    }
}