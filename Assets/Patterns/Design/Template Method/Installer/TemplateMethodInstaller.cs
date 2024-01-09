using Zenject;

namespace TemplateMethod
{
    public class TemplateMethodInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<InputHandler>().FromNew().AsSingle();

#if UNITY_EDITOR
            Container.BindInterfacesAndSelfTo<LogReader>().FromNew().AsSingle().WithArguments(new FullLog());
#else
            Container.BindInterfacesAndSelfTo<LogReader>().FromNew().AsSingle().WithArguments(new DefaultLog());
#endif
        }
    }
}
