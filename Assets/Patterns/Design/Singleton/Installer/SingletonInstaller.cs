using Zenject;

namespace Singleton
{
    public class SingletonInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<InputHandler>().FromNew().AsSingle();

            Container.BindInterfacesAndSelfTo<Game>().FromNew().AsSingle();
        }
    }
}
