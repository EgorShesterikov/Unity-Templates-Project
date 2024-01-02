
namespace TypeObject
{
    public class Breed
    {
        private Breed _parent;
        private int _health;
        private int _attack;

        public Breed(Breed parent, int health, int attack)
        {
            _parent = parent;
            _health = health;
            _attack = attack;

            // Inheritance of undefined attributes
            if (parent != null)
            {
                if (health == 0)
                    _health = parent.Health;
                if (attack == 0)
                    _attack = parent.Attack;
            }
        }

        public int Health => _health;
        public int Attack => _attack;

        public Monster NewMonster() => new Monster(this);
    }
}
