using UnityEngine;

namespace Controllers.States
{
    public abstract class BaseState : IPlayerState
    {
        private readonly IInputController _inputController;

        protected BaseState(IInputController inputController)
        {
            _inputController = inputController;
        }
        
        public abstract void OnLeftMouseButton();

        public abstract void OnRightMouseButton();
        
        protected (int X, int Y) GetCoordinatesUnderCursor()
        {
            var mousePosition = _inputController.GetMousePosition();
            //todo: 
            return (0, 0);
        }
    }
}