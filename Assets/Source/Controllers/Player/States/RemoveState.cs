namespace Controllers.States
{
    public class RemoveState : BaseState
    {
        private readonly BuildingController _buildingController;

        public RemoveState(IInputController inputController, BuildingController buildingController) : base(inputController)
        {
            _buildingController = buildingController;
        }

        public override void OnLeftMouseButton()
        {
            var coordinates = GetCoordinatesUnderCursor();
            _buildingController.RemoveBuildingAt(coordinates.X, coordinates.Y);
        }

        public override void OnRightMouseButton()
        {
            throw new System.NotImplementedException();
        }
    }
}