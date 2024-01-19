namespace Decorator
{
    public class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza pizza) : base(pizza.Name + ", with cheese", pizza)
        { }

        public override int GetCost()
            => _pizza.GetCost() + 5;
    }
}
