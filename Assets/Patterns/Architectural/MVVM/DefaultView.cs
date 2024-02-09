using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace MVVM
{
    public class DefaultView : View, IDisposable
    {
        [SerializeField] private TextMeshProUGUI _textScore;

        [SerializeField] private Button _addScore;
        [SerializeField] private Button _saveScore;
        [SerializeField] private Button _resetScore;

        public override void Constructor(ViewModel viewModel)
        {
            base.Constructor(viewModel);

            _addScore.onClick.AddListener(_viewModel.IncreasePropertyScore);
            _saveScore.onClick.AddListener(_viewModel.OnSaveButtonClicked);
            _resetScore.onClick.AddListener(_viewModel.OnResetButtonClicked);

            _textScore.text = _viewModel.ScoreView.Value.ToString();
        }

        protected override void AddDispose()
        {
            _addScore.onClick.RemoveListener(_viewModel.IncreasePropertyScore);
            _saveScore.onClick.RemoveListener(_viewModel.OnSaveButtonClicked);
            _resetScore.onClick.RemoveListener(_viewModel.OnResetButtonClicked);
        }

        protected override void DisplayScoreView(int val)
            => _textScore.text = val.ToString();
    }
}
