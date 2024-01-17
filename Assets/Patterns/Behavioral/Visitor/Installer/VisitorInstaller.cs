using Zenject;

namespace Visitor
{
    public class VisitorInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            EnemySpawner spawner = new EnemySpawner();

            spawner.Spawn(EnemyTypes.Elf);
            spawner.Spawn(EnemyTypes.Ork);
            spawner.Spawn(EnemyTypes.Robot);
        }
    }
}
