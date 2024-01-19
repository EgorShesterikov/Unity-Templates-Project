using System.Text;

namespace Builder
{
    public class Bread
    { 
        public Flour Flour { get; set; }
        public Salt Salt { get; set; }
        public Additives Additives { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (Flour != null)
                stringBuilder.Append(Flour.Sort + "\n");

            if (Salt != null)
                stringBuilder.Append("Salt \n");

            if (Additives != null)
                stringBuilder.Append("Additives: " + Additives.Name + "\n");

            return stringBuilder.ToString();
        }
    }
}
