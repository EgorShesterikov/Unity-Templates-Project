using UnityEngine;

namespace DirtyFlag
{
    public class GraphNode
    {
        private const int MAX_CHILDREN = 5;

        private Position _local;
        private Mesh _mesh;

        private GraphNode[] _children;

        private Position _world = new Position();
        private bool _isDirty = true;

        public GraphNode(Position local, Mesh mesh, GraphNode[] children)
        {
            _local = local;
            _mesh = mesh;

            if (children != null)
            {
                _children = children;
            }
        }

        public void SetTransform(Position local)
        {
            _local = local;
            _isDirty = true;
        }

        public void Render(Position parentWorld, bool isDirty)
        {
            isDirty |= _isDirty;

            if (isDirty)
            {
                _world = _local.Combine(parentWorld);
                _isDirty = false;
            }
            else
            {
                Debug.Log("The object has not been changed");
            }

            if (_mesh)
            {
                RendererMesh(_mesh, _world);
            }

            if (_children != null)
            {
                for (int i = 0; i < _children.Length; i++)
                {
                    _children[i].Render(_world, isDirty);
                }
            }
        }

        private void RendererMesh(Mesh mesh, Position world)
            => Debug.Log("Renderer Mesh");
    }
}
