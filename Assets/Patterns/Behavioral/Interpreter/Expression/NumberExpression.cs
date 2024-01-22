namespace Interpreter
{
    public class NumberExpression : IExpression
    {
        private string _name;

        public NumberExpression(string variableName)
            => _name = variableName;

        public int Interpret(Context context)
            => context.GetVariable(_name);
    }
}
