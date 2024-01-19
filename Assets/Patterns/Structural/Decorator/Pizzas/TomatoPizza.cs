namespace Decorator
{
    public class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza pizza) : base(pizza.Name + ", with tomatoes", pizza)
        { }

        public override int GetCost()
            => _pizza.GetCost() + 3;
    }
}
