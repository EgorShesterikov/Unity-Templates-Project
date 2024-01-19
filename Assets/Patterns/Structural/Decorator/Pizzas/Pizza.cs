namespace Decorator
{
    public abstract class Pizza
    {
        public Pizza(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        public abstract int GetCost();
    }
}
