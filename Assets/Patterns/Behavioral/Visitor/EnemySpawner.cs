using UnityEngine;

namespace Visitor
{
    public class EnemySpawner
    {
        private EnemyVisitor _enemyVisitor;

        public EnemySpawner()
            => _enemyVisitor = new EnemyVisitor();

        public void Spawn(EnemyTypes typeEnemy)
        {
            Enemy enemy;

            switch (typeEnemy)
            {
                case EnemyTypes.Elf:
                    enemy = new Elf();
                    break;

                case EnemyTypes.Ork:
                    enemy = new Ork();
                    break;

                case EnemyTypes.Robot:
                    enemy = new Robot();
                    break;

                default:
                    throw new System.NotImplementedException();
            }

            enemy.Accept(_enemyVisitor);

            // Project Settings -> Other settings -> Api Compatibility Level* -> .NET Framework
            // _enemyVisitor.Visit(enemy);
        }

        private class EnemyVisitor : IEnemyVisitor
        {
            // Project Settings -> Other settings -> Api Compatibility Level* -> .NET Framework
            // public void Visit(Enemy enemy) => Visit((dynamic)enemy);

            public void Visit(Elf elf)
                => Debug.Log("Type enemy: Elf!");

            public void Visit(Ork ork)
                => Debug.Log("Type enemy: Ork!");

            public void Visit(Robot robot)
                => Debug.Log("Type enemy: Robot!");
        }
    }
}
