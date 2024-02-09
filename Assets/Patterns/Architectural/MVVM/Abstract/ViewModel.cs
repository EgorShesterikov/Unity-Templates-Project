using UnityEngine;

namespace MVVM
{
    public abstract class ViewModel
    {
        public ReactiveProperty<int> ScoreView = new();

        protected Model _model; 

        public ViewModel(Model model)
        {
            _model = model;

            _model.Score.OnChanged += OnModelScoreChanged;
        }

        public void IncreasePropertyScore()
            => ScoreView.Value += 1;

        public void OnResetButtonClicked()
            => ScoreView.Value = _model.Score.Value;

        public void OnSaveButtonClicked()
            => _model.Score.Value = ScoreView.Value;

        private void OnModelScoreChanged(int val)
            => ScoreView.Value = val;
    }
}
