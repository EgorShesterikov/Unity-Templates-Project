namespace State
{
    public abstract class DefaultState : IState
    {
        protected IStateSwitcher _stateSwitcher;
        protected InputHandler _input;

        protected StateMachineData _data;

        public DefaultState(IStateSwitcher stateSwitcher, InputHandler input, StateMachineData data)
        {
            _stateSwitcher = stateSwitcher;
            _input = input;
            _data = data;
        }

        abstract public void Enter();

        abstract public void Exit();

        abstract public void Tick();
    }
}
