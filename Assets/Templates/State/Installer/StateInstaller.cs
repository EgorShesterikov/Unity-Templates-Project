using Zenject;

namespace State
{
    public class StateInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<InputHandler>().FromNew().AsSingle();

            Container.BindInterfacesAndSelfTo<StateMachine>().FromNew().AsSingle().NonLazy();
        }
    }
}
