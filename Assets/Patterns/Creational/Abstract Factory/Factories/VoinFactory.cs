namespace AbstractFactory
{
    public class VoinFactory : HeroFactory
    {
        public override Movement CreateMovement()
            => new RunMovement();

        public override Weapon CreateWeapon()
            => new Sword();
    }
}
