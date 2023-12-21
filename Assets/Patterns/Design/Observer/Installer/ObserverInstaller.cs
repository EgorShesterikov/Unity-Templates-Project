using Zenject;

namespace Observer
{
    public class ObserverInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<InputHandler>().FromNew().AsSingle();

            Container.BindInterfacesAndSelfTo<AchievementObserver>().FromNew().AsSingle();

            Container.BindInterfacesAndSelfTo<EventPoster>().FromNew().AsSingle();   
        }
    }
}
