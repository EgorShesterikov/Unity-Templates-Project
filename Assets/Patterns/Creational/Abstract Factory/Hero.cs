using System;

namespace AbstractFactory
{
    public class Hero : IDisposable
    {
        private Weapon _weapon;
        private Movement _movement;

        private InputHandler _input;

        public Hero(HeroFactory factory, InputHandler input)
        {
            _weapon = factory.CreateWeapon();
            _movement = factory.CreateMovement();

            _input = input;
            _input.ClickedSpace += Run;
            _input.ClickedLBM += Hit;
        }

        public void Dispose()
        {
            _input.ClickedSpace -= Run;
            _input.ClickedLBM -= Hit;
        }

        public void Run()
            => _movement.Move();

        public void Hit()
            => _weapon.Hit();
    }
}
