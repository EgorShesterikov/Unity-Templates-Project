using System;

namespace TemplateMethod
{
    public class LogReader : IDisposable
    {
        private InputHandler _input;

        private BaseLog _log;

        public LogReader(InputHandler input, BaseLog log)
        {
            _input = input;
            _input.ClickedSpace += ViewLog;

            _log = log;
        }
        public void Dispose()
        {
            _input.ClickedSpace += ViewLog;
        }

        public void ViewLog()
            => _log.WriteLog();
    }
}
