namespace Command
{
    public class JumpCommand : ICommand
    {
        public void Execute()
            => UnityEngine.Debug.Log("Jump");
    }
}