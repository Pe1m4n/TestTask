using UnityEngine;

namespace State.Extensions
{
    public static class TileGridExtensions
    {
        public static bool IsTileEmpty(this TileGridState tileGridState, int x, int y)
        {
            if (tileGridState.TryGetTile(x, y, out var tile))
            {
                return !tile.Occupied;
            }
            
            Debug.LogError($"There's no tile with coordinates [{x},{y}]");
            return false;
        }

        public static bool IsValidCoordinates(this TileGridState tileGridState, int x, int y)
        {
            return !(x < 0 || y < 0 || x >= tileGridState.Width || y >= tileGridState.Height);
        }

        private static bool TryGetTile(this TileGridState tileGridState, int x, int y, out TileState tileState)
        {
            tileState = null;
            if (!tileGridState.IsValidCoordinates(x, y))
            {
                return false;
            }

            tileState = tileGridState.Tiles[x, y];
            return true;
        }
    }
}