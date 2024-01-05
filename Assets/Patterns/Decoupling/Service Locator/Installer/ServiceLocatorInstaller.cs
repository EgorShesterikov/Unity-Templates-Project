using Zenject;

namespace ServiceLocator
{
    public class ServiceLocatorInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<InputHandler>().FromNew().AsSingle();

            Container.BindInterfacesAndSelfTo<AudioController>().FromNew().AsSingle();

            Locator.Initialize();
            Locator.Provide(new ServiceAudio());
        }
    }
}