namespace MVC
{
    public abstract class  Model
    {
        protected View _view;
        
        private int _score;

        public Model(View view)
        {
            _view = view;
            _score = 0;
        }

        public void AddScore()
        {
            _score++;
            _view.DisplayScoreText(_score);
        }
    }
}
