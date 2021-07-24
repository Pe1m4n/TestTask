using System;
using Controllers;
using State;
using UnityEngine;
using View;
using Object = UnityEngine.Object;

namespace DefaultNamespace
{
    public class GameLoop : MonoBehaviour
    {
        [SerializeField] private TileView _tilePrefab;
        [SerializeField] private int _width; 
        [SerializeField] private int _height;
        [SerializeField] private float _tileShift;

        [SerializeField] private UIController _uiController;
        
        private GameState _state;
        private readonly InputController _inputController = new InputController();
        private PlayerController _playerController;
        private BuildingController _buildingController;

        private void Awake()
        {
            _state = new GameState(_width, _height);
            _buildingController = new BuildingController(_state);

            foreach (var tile in _state.TileGridState.Tiles)
            {
                var position = new Vector3(tile.X * _tileShift, 0, tile.Y * _tileShift);
                var tileView = Instantiate(_tilePrefab, position, Quaternion.identity);
                tileView.Initialize(tile);
            }
            
            _playerController = new PlayerController(_buildingController, _inputController);
        }

        private void Start()
        {
            _uiController.Initialize(_playerController);
        }

        private void Update()
        {
            _inputController.CollectInputs();
            //Logic here
            _playerController.Update();
            //End of logic
            _inputController.ClearInputs();
        }
    }
}