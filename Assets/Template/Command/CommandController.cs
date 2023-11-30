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

            _inputHandler.ClickedAlpha1 += () => _factory.Get<AttackCommand>().Execute();
            _inputHandler.ClickedAlpha2 += () => _factory.Get<JumpCommand>().Execute();
            _inputHandler.ClickedAlpha3 += () => _factory.Get<MoveCommand>().Execute();
        }

        public void Dispose()
        {
            _inputHandler.ClickedAlpha1 -= () => _factory.Get<AttackCommand>().Execute();
            _inputHandler.ClickedAlpha2 -= () => _factory.Get<JumpCommand>().Execute();
            _inputHandler.ClickedAlpha3 -= () => _factory.Get<MoveCommand>().Execute();
        }        
    }
}
