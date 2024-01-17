using System;

namespace Mediator
{
    public class MainMenu : WindowForm, IDisposable
    {
        public event Action ClickedPlayButton;

        private InputHandler _input;

        public MainMenu(InputHandler input)
        {
            _input = input;
            _input.ClickedAlpha1 += ClickPlayButton;
        }

        public void Dispose()
        {
            _input.ClickedAlpha1 -= ClickPlayButton;
        }

        public void ClickPlayButton()
        {
            ClickedPlayButton?.Invoke();
        }
    }
}