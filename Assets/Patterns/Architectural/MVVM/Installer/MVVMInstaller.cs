using Zenject;
using UnityEngine;

namespace MVVM
{
    public class MVVMInstaller : MonoInstaller
    {
        [SerializeField] private View _view;
        public override void InstallBindings()
        {
            Container.BindInstance(_view).AsSingle();

            Container.Bind(typeof(ViewModel)).To<DefaultViewModel>().FromNew().AsSingle();
            Container.Bind(typeof(Model)).To<DefaultModel>().FromNew().AsSingle();
        }
    }
}
