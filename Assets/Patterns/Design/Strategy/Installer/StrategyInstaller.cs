using Zenject;

namespace Strategy
{
    public class StrategyInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<InputHandler>().FromNew().AsSingle();

            Container.BindInterfacesAndSelfTo<LogReader>().FromNew().AsSingle();
            Container.BindInterfacesAndSelfTo<LogChanger>().FromNew().AsSingle();
        }
    }
}
