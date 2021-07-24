namespace Controllers
{
    public class PlayerStateMachine
    {
        private IPlayerState _currentState;

        public PlayerStateMachine(IPlayerState defaultState)
        {
            _currentState = defaultState;
        }
        
        public void SetState(IPlayerState state)
        {
            _currentState = state;
        }

        public void OnLeftMouseButton()
        {
            _currentState.OnLeftMouseButton();
        }

        public void OnRightMouseButton()
        {
            _currentState.OnRightMouseButton();
        }
    }
}