namespace StatePattern
{
    public class GameStateMachine
    {
        public IState CurrentState { get; private set; }
        
        public void ChangeState(IState nextState)
        {
            if (ReferenceEquals(CurrentState, nextState)) return;
            
            CurrentState?.Exit();
            CurrentState = nextState;
            CurrentState.Enter();
        }
    }
}