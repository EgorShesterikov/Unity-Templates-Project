using UnityEngine;
using Zenject;

namespace Builder
{
    public class BuilderInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Baker baker = new Baker();

            BreadBuilder ryeBuilder = new RyeBreadBuilder();
            Bread ryeBread = baker.Bake(ryeBuilder);
            Debug.Log(ryeBread.ToString());

            BreadBuilder wheatBuilder = new WheatBreadBuilder();
            Bread wheatBread = baker.Bake(wheatBuilder);
            Debug.Log(wheatBread.ToString());
        }
    }
}
