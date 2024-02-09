using System;
using UnityEngine;
using Zenject;

namespace MVVM
{
    public abstract class View : MonoBehaviour, IDisposable
    {
        protected ViewModel _viewModel;

        [Inject]
        public virtual void Constructor(ViewModel viewModel)
        {
            _viewModel = viewModel;

            _viewModel.ScoreView.OnChanged += DisplayScoreView;
        }

        public void Dispose()
        {
            _viewModel.ScoreView.OnChanged -= DisplayScoreView;

            AddDispose();
        }

        protected abstract void DisplayScoreView(int val);

        protected abstract void AddDispose();
    }
}
