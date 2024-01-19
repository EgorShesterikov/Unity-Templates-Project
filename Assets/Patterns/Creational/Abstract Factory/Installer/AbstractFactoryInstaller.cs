using Zenject;

namespace AbstractFactory
{
    public class AbstractFactoryInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<InputHandler>().FromNew().AsSingle();

            Container.Bind<HeroFactory>().To<ElfFactory>().FromNew().AsSingle();

            Container.BindInterfacesAndSelfTo<Hero>().FromNew().AsSingle().NonLazy();            
        }
    }
}
