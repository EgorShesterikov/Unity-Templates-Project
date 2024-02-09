using Zenject;
using UnityEngine;

namespace MVP
{
    public class MVPInstaller : MonoInstaller
    {
        [SerializeField] private View _view;

        public override void InstallBindings()
        {
            Container.Bind(typeof(Presenter)).To<DefaultPresenter>().FromNew().AsSingle();
            Container.Bind(typeof(Model)).To<DefaultModel>().FromNew().AsSingle();
            Container.BindInstance(_view).AsSingle();
        }
    }
}
