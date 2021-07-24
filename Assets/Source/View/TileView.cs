using State;
using UnityEngine;

namespace View
{
    public class TileView : MonoBehaviour
    {
        [SerializeField] private Material _material;
        
        private TileState _state;

        public int X => _state.X;
        public int Y => _state.Y;
            
        public void Initialize(TileState state)
        {
            _state = state;
        }

        private void Update()
        {
            if (_state == null)
            {
                return;
            }

            _material.color = _state.Occupied ? Color.red : Color.green;
        }
    }
}