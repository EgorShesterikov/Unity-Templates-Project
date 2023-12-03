namespace Prototype
{
    public abstract class Unit : IUnitPrototype
    {
        protected int _damage;
        protected int _heal;
        protected int _speed;
        
        public Unit(int damage, int heal, int speed)
        {
            _damage = damage;
            _heal = heal;
            _speed = speed;
        }

        public int Damage => _damage;
        public int Heal => _heal;
        public int Speed => _speed;

        virtual public Unit Clone()
            => throw new System.NotImplementedException();
    }

}