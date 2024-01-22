using Zenject;

namespace Memento
{
    public class MementoInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            GameHistory game = new GameHistory();
            Hero hero = new Hero();

            hero.Shoot();

            game.History.Push(hero.SaveState());

            hero.Shoot();

            hero.RestoreState(game.History.Pop());

            hero.Shoot();
        }
    }
}
