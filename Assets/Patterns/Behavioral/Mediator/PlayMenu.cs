using System;

namespace Mediator
{
    public class PlayMenu : WindowForm, IDisposable
    {
        public event Action ClickedMenuButton;

        private InputHandler _input;

        public PlayMenu(InputHandler input)
        {
            _input = input;
            _input.ClickedAlpha2 += ClickMenuButton;
        }

        public void Dispose()
        {
            _input.ClickedAlpha2 -= ClickMenuButton;
        }

        public void ClickMenuButton()
        {
            ClickedMenuButton?.Invoke();
        }
    }
}