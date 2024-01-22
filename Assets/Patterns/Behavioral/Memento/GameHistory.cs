using System.Collections.Generic;

namespace Memento
{
    public class GameHistory
    {
        public Stack<HeroMemento> History { get; private set; }

        public GameHistory()
            => History = new Stack<HeroMemento>();
    }
}
