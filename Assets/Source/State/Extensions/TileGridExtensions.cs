using UnityEngine;

namespace State.Extensions
{
    public static class TileGridExtensions
    {
        public static bool IsTileEmpty(this TileGrid tileGrid, int x, int y)
        {
            if (tileGrid.TryGetTile(x, y, out var tile))
            {
                return !tile.Occupied;
            }
            
            Debug.LogError($"There's no tile with coordinates [{x},{y}]");
            return false;
        }

        public static bool IsValidCoordinates(this TileGrid tileGrid, int x, int y)
        {
            return !(x < 0 || y < 0 || x >= tileGrid.Width || y >= tileGrid.Height);
        }

        private static bool TryGetTile(this TileGrid tileGrid, int x, int y, out Tile tile)
        {
            tile = null;
            if (!tileGrid.IsValidCoordinates(x, y))
            {
                return false;
            }

            tile = tileGrid.Tiles[x, y];
            return true;
        }
    }
}