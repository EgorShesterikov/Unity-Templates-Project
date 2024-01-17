using System;

namespace Strategy
{
    public class LogReader : IDisposable
    {
        private InputHandler _input;

        private ILog _logStategy;

        public LogReader(InputHandler input)
        {
            _input = input;
            _input.ClickedSpace += ViewLog;

            ChangeTypeLog(new DefaultLog());
        }
        public void Dispose()
        {
            _input.ClickedSpace += ViewLog;
        }

        public void ChangeTypeLog(ILog logType)
            => _logStategy = logType;
       
        public void ViewLog()
            => _logStategy.WriteLog();
    }
}
