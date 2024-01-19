using Zenject;

namespace Facade
{
    public class FacadeInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            TextEditor textEditor = new TextEditor();
            Compiller compiller = new Compiller();
            CLR clr = new CLR(); 

            VisualStudioFacade ide = new VisualStudioFacade(textEditor, compiller, clr);

            Programmer programmer = new Programmer();
            programmer.CreateApplication(ide);
        }
    }
}
