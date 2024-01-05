using Zenject;

namespace DataLocality
{
    public class DataLocalityInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<ParticleMachine>().FromNew().AsSingle().NonLazy();
        }
    }
}