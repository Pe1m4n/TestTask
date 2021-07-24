using System.Collections.Generic;

namespace State
{
    public class GameState
    {
        public TileGridState TileGridState { get; }
        public List<BuildingState> Buildings { get; } = new List<BuildingState>();

        public GameState(int gridWidth, int gridHeight)
        {
            TileGridState = new TileGridState(gridWidth, gridHeight);
        }
    }
}