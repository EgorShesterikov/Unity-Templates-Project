using Zenject;

namespace Mediator
{
    public class MediatorInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<InputHandler>().FromNew().AsSingle();

            Container.BindInterfacesAndSelfTo<MainMenu>().FromNew().AsSingle();
            Container.BindInterfacesAndSelfTo<PlayMenu>().FromNew().AsSingle();

            Container.BindInterfacesAndSelfTo<UIMediator>().FromNew().AsSingle();
        }
    }
}
