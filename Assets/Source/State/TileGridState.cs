namespace State
{
    public class TileGridState
    {
        public int Width { get; }
        public int Height { get; }
        public TileState[,] Tiles { get; }

        public TileGridState(int width, int height)
        {
            Width = width;
            Height = height;
            Tiles = new TileState[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Tiles[x, y] = new TileState(x, y);
                }
            }
        }
    }
}