namespace Decorator
{
    public class BulgerianPizza : Pizza
    {
        public BulgerianPizza() : base("Bulgerian Pizza")
        { }

        public override int GetCost()
            => 8;
    }
}
