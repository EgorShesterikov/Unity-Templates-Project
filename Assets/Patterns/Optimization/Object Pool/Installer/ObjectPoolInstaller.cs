using Zenject;

namespace ObjectPool
{
    public class ObjectPoolInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<InputHandler>().FromNew().AsSingle();
            Container.BindInterfacesAndSelfTo<EffectsPool>().FromNew().AsSingle();

            Container.BindInterfacesTo<Game>().FromNew().AsSingle().NonLazy();
        }
    }
}