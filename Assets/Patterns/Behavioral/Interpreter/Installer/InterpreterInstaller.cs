using UnityEngine;
using Zenject;

namespace Interpreter
{
    public class InterpreterInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Context context = new Context();

            int x = 5;
            int y = 8;
            int z = 2;

            context.SetVariable("x", x);
            context.SetVariable("y", y);
            context.SetVariable("z", z);

            // x + y - z
            IExpression expression = new SubtractExpression(
                new AddExpression(
                    new NumberExpression("x"), new NumberExpression("y")
                    ),
                new NumberExpression("z")
            );

            int result = expression.Interpret(context);
            Debug.Log(result);
        }
    }
}
