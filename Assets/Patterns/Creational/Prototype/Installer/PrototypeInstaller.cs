using UnityEngine;
using Zenject;

namespace Prototype
{
    public class PrototypeInstaller : MonoInstaller
    {
        [SerializeField] private UnitTypes _unitType;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<InputHandler>().FromNew().AsSingle();

            Container.Bind<UnitFactory>().FromNew().AsSingle();

            Container.BindInterfacesAndSelfTo<UnitSpawner>().FromNew().AsSingle().WithArguments(_unitType);
        }
    }
}
