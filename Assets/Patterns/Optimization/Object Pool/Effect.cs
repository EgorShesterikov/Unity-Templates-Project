using UnityEngine;

namespace ObjectPool
{
    public class Effect
    {
        private Effect _next;

        private int _x, _y;
        private int _xVel, _yVel;

        private float _lifeTime;

        public void Init(int x, int y, int xVel,  int yVel, float lifeTime)
        {
            _x = x;
            _y = y;
            _xVel = xVel;
            _yVel = yVel;

            _lifeTime = lifeTime;
        }

        public Effect GetNext() => _next;
        public void SetNext(Effect next) => _next = next;

        public bool Animate()
        {
            if (IsUse() == false) return false;

            _lifeTime -= Time.deltaTime;

            _x += _xVel;
            _y += _yVel;

            Debug.Log($"Move particle: {_lifeTime}");

            return _lifeTime <= 0;
        }

        public bool IsUse() => _lifeTime > 0;
    }
}