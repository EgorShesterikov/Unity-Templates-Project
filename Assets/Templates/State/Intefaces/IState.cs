namespace State
{
    public interface IState
    {
        void Enter();
        void Exit();
        void Tick();
    }
}
