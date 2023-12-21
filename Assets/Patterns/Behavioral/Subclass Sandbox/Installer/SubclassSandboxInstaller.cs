using Zenject;

namespace SubclassSandbox
{
    public class SubclassSandboxInstaller : MonoInstaller
    {
        public override void InstallBindings()
            => Container.BindInterfacesAndSelfTo<SkyLaunch>().FromNew().AsSingle().NonLazy();
    }
}
