using System.Collections.Generic;

namespace Interpreter
{
    public class Context
    {
        private Dictionary<string, int> _variables;
        
        public Context()
            => _variables = new Dictionary<string, int>();

        public int GetVariable(string name)
            => _variables[name];

        public void SetVariable(string name, int value)
        {
            if(_variables.ContainsKey(name))
                _variables[name] = value;
            else
                _variables.Add(name, value);
        }
    }
}
