using System;

namespace Command
{
    public class CommandsFactory
    {
        public ICommand Get<T>() where T : ICommand
            => (T)Activator.CreateInstance(typeof(T));
    }
}
