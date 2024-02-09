using System;
using Zenject;
using UnityEngine;

namespace MVC
{
    public class MVCInstaller : MonoInstaller
    {
        [SerializeField] private View _view;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<InputHandler>().FromNew().AsSingle();

            Container.Bind(typeof(Controller), typeof(IDisposable)).To<DefaultController>().FromNew().AsSingle();
            Container.Bind(typeof(Model)).To<DefaultModel>().FromNew().AsSingle();
            Container.BindInstance(_view).AsSingle();
        }
    }
}
