using UnityEngine;
using Zenject;

namespace ObjectPool
{
    public class EffectsPool : ITickable
    {
        private const int POOL_SIZE = 2;
        private Effect[] _effects = new Effect[POOL_SIZE];

        private Effect _firstAvailable;

        public EffectsPool()
        {
            for (int i = 0; i < POOL_SIZE; i++)
                _effects[i] = new Effect();

            _firstAvailable = _effects[0];

            for (int i = 0; i < POOL_SIZE - 1; i++)
            {
                _effects[i].SetNext(_effects[i + 1]);
            }

            _effects[POOL_SIZE - 1].SetNext(null);
        }

        public void Create(int x, int y, int xVel, int yVel, int lifeTime)
        {
            if(_firstAvailable == null)
                throw new System.ArgumentNullException(nameof(_firstAvailable));

            Effect newEffect = _firstAvailable;
            _firstAvailable = newEffect.GetNext();

            newEffect.Init(x, y, xVel, yVel, lifeTime);
        }

        public void Tick()
        {
            for (int i = 0; i < POOL_SIZE; i++)
            {
                if(_effects[i].Animate())
                {
                    _effects[i].SetNext(_firstAvailable);
                    _firstAvailable = _effects[i];
                }
            }
        }
    }
}