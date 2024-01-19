using UnityEngine;

namespace Composite
{
    public abstract class Component
    {
        protected string _name;

        protected Component(string name)
            => _name = name;

        public virtual void Add(Component component) { }
        public virtual void Remove(Component component) { }
        
        public virtual void Print()
            => Debug.Log(_name);
    }
}
