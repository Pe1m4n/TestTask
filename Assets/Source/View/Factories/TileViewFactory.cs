using State;

namespace View.Factories
{
    public class TileViewFactory
    {
        private readonly TileView _viewPrefab;

        public TileViewFactory(TileView viewPrefab)
        {
            _viewPrefab = viewPrefab;
        }
    }
}