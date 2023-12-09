using UnityEngine;
using Zenject;

namespace DoubleBuffering
{
    public class DoubleBufferingInstaller : MonoInstaller
    {
        [SerializeField] private FrameBufferConfig _bufferConfig;

        public override void InstallBindings()
        {
            Container.BindInstance(_bufferConfig).AsSingle();

            Container.BindInterfacesAndSelfTo<FrameBuffer>().FromNew().AsCached();
            Container.BindInterfacesAndSelfTo<FrameBuffer>().FromNew().AsCached();

            Container.BindInterfacesAndSelfTo<Scene>().FromNew().AsSingle().NonLazy();
        }
    }
}
