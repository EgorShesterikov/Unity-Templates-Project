namespace AbstractFactory
{
    public class ElfFactory : HeroFactory
    {
        public override Movement CreateMovement()
            => new FlyMovement();

        public override Weapon CreateWeapon()
            => new Arbalet();
    }
}
