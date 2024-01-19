namespace Builder
{
    public class WheatBreadBuilder : BreadBuilder
    {
        public override void SetAdditives()
        {
            Bread.Additives = new Additives { Name = "Bread improver" };
        }

        public override void SetFlour()
        {
            Bread.Flour = new Flour { Sort = "Wheat flour: highest Sort" };
        }

        public override void SetSalt()
        {
            Bread.Salt = new Salt();
        }
    }
}
