namespace MVP
{
    public abstract class Presenter
    {
        protected Model _model;

        public Presenter(Model model) 
            => _model = model;

        public void OnAddButtonClicked()
            => UpdateScore();

        protected void UpdateScore()
            => _model.AddScore();
    }
}
