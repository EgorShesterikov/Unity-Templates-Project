namespace TemplateMethod
{
    public class DefaultLog : BaseLog
    {
        protected override string ReadDetails()
            => "Default log!";
    }
}
