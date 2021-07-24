using System;
using System.Linq;
using Controllers.States;
using UnityEngine;

namespace Controllers
{
    public class PlayerController
    {
        private readonly BuildingController _buildingController;
        private readonly IInputController _inputController;
        private PlayerStateMachine _stateMachine;
        
        public PlayerController(BuildingController buildingController, IInputController inputController)
        {
            _buildingController = buildingController;
            _inputController = inputController;
            _stateMachine = new PlayerStateMachine(new BuildState(_buildingController, _inputController, 1, 1));
        }
        
        public void Update()
        {
            var pressedKeys = _inputController.GetCurrentKeys();
            if (pressedKeys.Contains(KeyCode.Mouse0))
            {
                _stateMachine.OnLeftMouseButton();
            }

            if (pressedKeys.Contains(KeyCode.Mouse1))
            {
                _stateMachine.OnRightMouseButton();
            }
        }

        public void SetState(PlayerMode playerMode)
        {
            switch (playerMode)
            {
                case PlayerMode.Build1x1:
                    _stateMachine.SetState(new BuildState(_buildingController, _inputController, 1, 1));
                    break;
                case PlayerMode.Build2x2:
                    _stateMachine.SetState(new BuildState(_buildingController, _inputController, 2, 2));
                    break;
                case PlayerMode.Remove:
                    _stateMachine.SetState(new RemoveState(_inputController, _buildingController));
                    break;
            }
        }
    }
}