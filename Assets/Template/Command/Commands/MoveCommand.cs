namespace Command
{
    public class MoveCommand : ICommand
    {
        public void Execute()
            => UnityEngine.Debug.Log("Move");
    }
}