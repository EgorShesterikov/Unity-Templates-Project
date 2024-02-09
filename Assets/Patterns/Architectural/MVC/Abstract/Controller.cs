using System;

namespace MVC
{
    public abstract class Controller : IDisposable
    {
        protected View _view;
        protected Model _model;

        private InputHandler _input;

        public Controller(View view, Model model, InputHandler input) 
        {
            _view = view;
            _model = model;
            _input = input;

            _input.ClickedSpace += UpdateScore;
        }

        public void Dispose()
        {
            _input.ClickedSpace -= UpdateScore;
        }

        public void UpdateScore()
            => _model.AddScore();
    }
}
