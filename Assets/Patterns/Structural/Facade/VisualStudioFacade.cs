namespace Facade
{
    public class VisualStudioFacade
    {
        private TextEditor _textEditor;
        private Compiller _compiller;
        private CLR _clr;

        public VisualStudioFacade(TextEditor textEditor, Compiller compiller, CLR clr)
        {
            _textEditor = textEditor;
            _compiller = compiller;
            _clr = clr;
        }

        public void Start()
        {
            _textEditor.CreateCode();
            _textEditor.Save();
            _compiller.Compile();
            _clr.Execute();
        }

        public void Stop()
        {
            _clr.Finish();
        }
    }
}
