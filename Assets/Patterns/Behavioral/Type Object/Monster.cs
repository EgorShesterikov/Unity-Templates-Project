
namespace TypeObject
{
    public class Monster
    {
        private int _health;
        private Breed _breed;

        public Monster(Breed breed) 
        { 
            _health = breed.Health;
            _breed = breed;
        }

        public int Attack => _breed.Attack;
        public Breed Breed => _breed;

        public int CurrentHealth => _health;
    }
}
