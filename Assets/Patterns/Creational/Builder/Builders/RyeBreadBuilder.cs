namespace Builder
{
    public class RyeBreadBuilder : BreadBuilder
    {
        public override void SetAdditives()
        {
            // not used
        }

        public override void SetFlour()
        {
            Bread.Flour = new Flour { Sort = "Rye flour: 1 Sort" };
        }

        public override void SetSalt()
        {
            Bread.Salt = new Salt();
        }
    }
}
