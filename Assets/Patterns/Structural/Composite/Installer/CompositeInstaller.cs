using Zenject;

namespace Composite
{
    public class CompositeInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Component fileSystem = new Directory("File System");

            Component diskC = new Directory("Disk C");

            Component pngFile = new File("12345.png");
            Component docxFile = new File("Document.docx");

            diskC.Add(pngFile);
            diskC.Add(docxFile);

            fileSystem.Add(diskC);

            fileSystem.Print();

            diskC.Remove(pngFile);

            Component docsFolder = new Directory("My documents");

            Component txtFile = new File("readme.txt");
            Component csFile = new File("Program.cs");
            docsFolder.Add(txtFile);
            docsFolder.Add(csFile);

            diskC.Add(docsFolder);

            fileSystem.Print();
        }
    }
}
