using System;

namespace Prototype
{
    public class UnitSpawner : IDisposable
    {
        private InputHandler _input;

        private Unit _prototype;

        public UnitSpawner(InputHandler input, UnitFactory factory, UnitTypes type)
        {
            _input = input;
            _input.ClickedSpace += SpawnUnit;

            _prototype = factory.Get(type);
        }

        public void Dispose()
            => _input.ClickedSpace -= SpawnUnit;

        public void SpawnUnit()
            => _prototype.Clone();
    }
}
