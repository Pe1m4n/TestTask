using UnityEngine;

namespace Controllers.States
{
    public class BuildState : BaseState
    {
        private readonly BuildingController _buildingController;
        private readonly int _width;
        private readonly int _height;

        public BuildState(BuildingController buildingController,
            IInputController inputController,
            int width,
            int height) : base(inputController)
        {
            _buildingController = buildingController;
            _width = width;
            _height = height;
        }
        
        public override void OnLeftMouseButton()
        {
            var coordinates = GetCoordinatesUnderCursor();
            _buildingController.BuildAt(coordinates.X, coordinates.Y, _width, _height);
        }

        public override void OnRightMouseButton()
        {
        }
    }
}