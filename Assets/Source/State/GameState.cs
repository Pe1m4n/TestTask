using System.Collections.Generic;

namespace State
{
    public class GameState
    {
        public TileGrid TileGrid { get; }
        public List<Building> Buildings { get; } = new List<Building>();

        public GameState(int gridWidth, int gridHeight)
        {
            TileGrid = new TileGrid(gridWidth, gridHeight);
        }
    }
}