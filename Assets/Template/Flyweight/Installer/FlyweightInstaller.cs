using Zenject;

namespace Flyweight
{
    public class FlyweightInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<InputHandler>().FromNew().AsSingle();

            Container.Bind<TechnicalFactory>().FromNew().AsSingle();

            Container.BindInterfacesAndSelfTo<TechnicalService>().FromNew().AsSingle().NonLazy();
        }
    }
}
