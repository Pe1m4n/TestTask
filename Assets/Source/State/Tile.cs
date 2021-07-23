namespace State
{
    public class Tile
    {
        public int X { get; }
        public int Y { get; }
        public bool Occupied { get; set; }

        public Tile(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}