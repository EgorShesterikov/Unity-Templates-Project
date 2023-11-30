namespace Command
{
    public class AttackCommand : ICommand
    {
        public void Execute()
            => UnityEngine.Debug.Log("Attack");
    }
}