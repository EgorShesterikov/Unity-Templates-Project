using System;

namespace Strategy
{
    public class LogChanger : IDisposable
    {
        private InputHandler _input;
        private LogReader _logReader;

        public LogChanger(InputHandler input, LogReader logReader)
        {
            _input = input;
            _input.ClickedAlpha1 += SetDefaultLog;
            _input.ClickedAlpha2 += SetFullLog;

            _logReader = logReader;
        }

        public void Dispose()
        {
            _input.ClickedAlpha1 -= SetDefaultLog;
            _input.ClickedAlpha2 -= SetFullLog;
        }

        private void SetDefaultLog()
            => _logReader.ChangeTypeLog(new DefaultLog());

        private void SetFullLog()
            => _logReader.ChangeTypeLog(new FullLog());
    }
}
