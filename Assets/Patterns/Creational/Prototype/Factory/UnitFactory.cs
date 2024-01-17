namespace Prototype
{
    public class UnitFactory
    {
        public Unit Get(UnitTypes type)
        {
            switch (type)
            {
                case UnitTypes.War:
                    return new War(3, 5, 2);

                case UnitTypes.Archer:
                    return new Archer(5, 3, 3);

                case UnitTypes.Mage:
                    return new Mage(4, 2, 2);

                default:
                    throw new System.NotImplementedException();
            }
        }
    }
}