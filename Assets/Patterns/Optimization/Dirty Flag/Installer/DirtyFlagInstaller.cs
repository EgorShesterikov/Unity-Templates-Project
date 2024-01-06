using Zenject;

namespace DirtyFlag
{
    public class DirtyFlagInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            GraphNode[] children = new GraphNode[5] {
                new GraphNode(new Position(), null, null),
                new GraphNode(new Position(), null, null),
                new GraphNode(new Position(), null, null),
                new GraphNode(new Position(), null, null),
                new GraphNode(new Position(), null, null)
            };

            GraphNode core = new GraphNode(new Position(), null, children);

            core.Render(new Position(), false);
            core.Render(new Position(), false);
        }
    }
}