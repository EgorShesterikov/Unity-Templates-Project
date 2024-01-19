namespace Builder
{
    public class Baker
    { 
        public Bread Bake(BreadBuilder builder)
        {
            builder.CreateBread();
            builder.SetFlour();
            builder.SetSalt();
            builder.SetAdditives();

            return builder.Bread;
        }
    }

}
