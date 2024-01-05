using System;
using Zenject;

namespace DataLocality
{
    public class ParticleMachine : IInitializable, ITickable
    {
        private const int MAX_PARTICLES = 10;

        private int _numActive;
        private Particle[] _particles = new Particle[MAX_PARTICLES];

        public void Initialize()
        {
            for (int i = 0; i < MAX_PARTICLES; i++)
            {
                _particles[i] = new Particle();
                ActivateParticle(i);
            }
        }

        public void Tick()
        {
            for (int i = 0; i < _numActive; i++)
                _particles[i].Update();
        }

        public void ActivateParticle(int index)
        {
            if(index < _numActive)
                throw new IndexOutOfRangeException(nameof(index));

            Particle temp = _particles[_numActive];
            _particles[_numActive] = _particles[index];
            _particles[index] = temp;

            _numActive++;
        }

        public void DeactivateParticle(int index)
        {
            if(index >= _numActive)
                throw new IndexOutOfRangeException(nameof(index));
                
            _numActive--;

            Particle temp = _particles[_numActive];
            _particles[_numActive] = _particles[index];
            _particles[index] = temp;
        }
    }
}
