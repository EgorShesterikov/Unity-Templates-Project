using UnityEngine;

namespace Memento
{
    public class Hero
    {
        private int _patrons = 10;
        private int _lives = 5;

        public void Shoot()
        {
            if(_patrons > 0)
            {
                _patrons--;
                Debug.Log($"Shoot! (Patrons count: {_patrons})");
            }
            else
            {
                Debug.Log("No patrons");
            }
        }

        public HeroMemento SaveState()
        {
            Debug.Log($"Save state: Patrons = {_patrons}, Lives = {_lives}");
            return new HeroMemento(_patrons, _lives);
        }

        public void RestoreState(HeroMemento memento)
        {
            _patrons = memento.Patrons;
            _lives = memento.Lives;
            Debug.Log($"Restore state: Patrons = {_patrons}, Lives = {_lives}");
        }
    }
}
