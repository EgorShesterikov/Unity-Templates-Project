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
            _input.ClickedSpace += WriteLog;
        }

        public void Dispose()
            => _input.ClickedSpace -= WriteLog;

        private void WriteLog()
            => Log.Instance.WriteLog(LogInfo);
    }
}