using Zenject;

namespace Command
{
    public class CommandInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<InputHandler>().FromNew().AsSingle();

            Container.Bind<CommandsFactory>().FromNew().AsSingle();

            Container.BindInterfacesAndSelfTo<CommandController>().FromNew().AsSingle().NonLazy();
        }
    }
}
