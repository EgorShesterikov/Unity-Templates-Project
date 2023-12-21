using Zenject;

namespace Bytecode
{
    public class BytecodeInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<MagicalAPI>().FromNew().AsSingle();

            Container.BindInterfacesAndSelfTo<VirtualMachine>().FromNew().AsSingle().NonLazy();
        }
    }
}
