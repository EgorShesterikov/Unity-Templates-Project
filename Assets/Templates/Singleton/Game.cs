using System;

namespace Singleton
{
    public class Game : IDisposable
    {
        private const string LogInfo = "Recorded in the log: Input space";

        private InputHandler _input;

        public Game(InputHandler input)
        {
            _input = input;
            _input.ClickedSpace += () => Log.Instance.WriteLog(LogInfo);
        }

        public void Dispose()
            => _input.ClickedSpace -= () => Log.Instance.WriteLog(LogInfo);
    }
}