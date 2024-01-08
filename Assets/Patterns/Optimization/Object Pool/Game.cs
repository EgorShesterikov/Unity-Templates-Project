using System;

namespace ObjectPool
{
    public class Game : IDisposable
    {
        private InputHandler _input;
        private EffectsPool _pool;

        public Game(InputHandler input, EffectsPool pool)
        {
            _input = input;
            _pool = pool;

            _input.ClickedSpace += TakePool;
        }

        public void Dispose()
            => _input.ClickedSpace -= TakePool;

        private void TakePool()
            => _pool.Create(0, 0, 1, 1, 2);
    }
}