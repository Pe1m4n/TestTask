namespace State
{
    public class TileGrid
    {
        public int Width { get; }
        public int Height { get; }
        public Tile[,] Tiles { get; }

        public TileGrid(int width, int height)
        {
            Width = width;
            Height = height;
            Tiles = new Tile[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Tiles[x, y] = new Tile(x, y);
                }
            }
        }
    }
}