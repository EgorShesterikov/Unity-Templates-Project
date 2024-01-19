using System.Collections.Generic;
using UnityEngine;

namespace Composite
{
    public class Directory : Component
    {
        private List<Component> _components = new List<Component>();

        public Directory(string name) : base(name) { }

        public override void Add(Component component)
            => _components.Add(component);
        public override void Remove(Component component)
            => _components.Remove(component);

        public override void Print()
        {
            Debug.Log("Node: " + _name);
            Debug.Log("Sub-Nodes:");

            for (int i = 0; i < _components.Count; i++)
                _components[i].Print();
        }
    }
}
