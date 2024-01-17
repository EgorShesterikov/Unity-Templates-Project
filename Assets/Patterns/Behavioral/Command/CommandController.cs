using System;
using Zenject;

namespace Command
{
    public class CommandController : IDisposable
    {
        private CommandsFactory _factory;

        private InputHandler _inputHandler;

        [Inject]
        public void Construct(CommandsFactory factory, InputHandler inputHandler)
        {
            _factory = factory;

            _inputHandler = inputHandler;

            _inputHandler.ClickedAlpha1 += AttackCommandExecute;
            _inputHandler.ClickedAlpha2 += JumpCommandExecute;
            _inputHandler.ClickedAlpha3 += MoveCommandExecute;
        }

        public void Dispose()
        {
            _inputHandler.ClickedAlpha1 -= AttackCommandExecute;
            _inputHandler.ClickedAlpha2 -= JumpCommandExecute;
            _inputHandler.ClickedAlpha3 -= MoveCommandExecute;
        }

        private void AttackCommandExecute()
            => _factory.Get<AttackCommand>().Execute();
        private void JumpCommandExecute()
            => _factory.Get<JumpCommand>().Execute();
        private void MoveCommandExecute()
            => _factory.Get<MoveCommand>().Execute();
    }
}
