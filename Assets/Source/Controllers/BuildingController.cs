using System;
using State;
using State.Extensions;

namespace Controllers
{
    public class BuildingController
    {
        private readonly GameState _state;

        public BuildingController(GameState state)
        {
            _state = state;
        }

        public bool IsValidToBuildAt(int x, int y, int buildingWidth, int buildingHeight)
        {
            for (int targetX = x; targetX < x + buildingWidth; targetX++)
            for (int targetY = y; targetY < y + buildingHeight; targetY++)
            {
                if (!_state.TileGridState.IsValidCoordinates(targetX, targetY))
                {
                    return false;
                }

                if (!_state.TileGridState.IsTileEmpty(targetX, targetY))
                {
                    return false;
                }
            }

            return true;
        }

        public void BuildAt(int x, int y, int buildingWidth, int buildingHeight)
        {
            if (!IsValidToBuildAt(x, y, buildingWidth, buildingHeight))
            {
                throw new InvalidOperationException(
                    $"Can't set building with width={buildingWidth} and height={buildingHeight} at [{x},{y}");
            }
            
            for (int targetX = x; targetX < x + buildingWidth; targetX++)
            for (int targetY = y; targetY < y + buildingHeight; targetY++)
            {
                _state.TileGridState.Tiles[targetX, targetY].Occupied = true;
            }
            
            _state.Buildings.Add(new BuildingState(x, y, buildingWidth, buildingHeight));
        }

        public void RemoveBuildingAt(int x, int y)
        {
            if (!_state.TileGridState.IsValidCoordinates(x, y))
            {
                return;
            }
            
            for (int i = 0; i < _state.Buildings.Count; i++)
            {
                var building = _state.Buildings[i];

                if (x >= building.X && y >= building.Y && x < building.X + building.Width &&
                    y < building.Y + building.Height)
                {
                    _state.Buildings.RemoveAt(i);
                    //TODO: make tiles empty
                    return;
                }
            }
        }
    }
}