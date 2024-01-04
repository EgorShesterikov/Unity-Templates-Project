using Zenject;

namespace EventQueue
{
    public class EventQueueInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<Audio>().FromNew().AsSingle();

            Container.BindInterfacesAndSelfTo<InputHandler>().FromNew().AsSingle();

            Container.BindInterfacesAndSelfTo<SoundCaster>().FromNew().AsSingle();

            Audio.Init();
        }
    }
}
