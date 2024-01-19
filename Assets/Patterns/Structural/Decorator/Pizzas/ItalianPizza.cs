namespace Decorator
{
    public class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Italian Pizza")
        { }

        public override int GetCost()
            => 10;
    }
}
