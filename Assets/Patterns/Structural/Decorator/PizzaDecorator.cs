namespace Decorator
{
    public abstract class PizzaDecorator : Pizza
    {
        protected Pizza _pizza;

        public PizzaDecorator(string name, Pizza pizza) : base(name)
        {
            this._pizza = pizza;
        }
    }
}
