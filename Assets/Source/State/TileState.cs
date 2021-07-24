namespace State
{
    public class TileState
    {
        public int X { get; }
        public int Y { get; }
        public bool Occupied { get; set; }

        public TileState(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}