using Zenject;

namespace Component
{
    public class ComponentInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<ActorInputComponent>().FromNew().AsSingle();
            Container.BindInterfacesAndSelfTo<ActorPhysicsComponent>().FromNew().AsSingle();
            Container.BindInterfacesAndSelfTo<ActorSpriteComponent>().FromNew().AsSingle();

            Container.BindInterfacesAndSelfTo<Actor>().FromNew().AsSingle().NonLazy();
        }
    }
}
