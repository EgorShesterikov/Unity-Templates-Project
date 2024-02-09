using UnityEngine;
using Zenject;

namespace MVP
{
    public abstract class View : MonoBehaviour
    {
        protected Presenter _presenter;

        [Inject]
        public void Constructor(Presenter presenter)
            => _presenter = presenter;

        public abstract void DisplayScoreText(int values);
    }
}
