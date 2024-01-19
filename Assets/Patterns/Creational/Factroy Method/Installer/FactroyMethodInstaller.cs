using Zenject;

namespace FactroyMethod
{
    public class FactroyMethodInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Developer dev_1 = new PanelDeveloper("Panel Dev");
            House house_1 = dev_1.Create();

            Developer dev_2 = new WoodDeveloper("Wood Dev");
            House house_2 = dev_2.Create();
        }
    }
}
