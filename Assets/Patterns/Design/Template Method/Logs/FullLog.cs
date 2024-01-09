namespace TemplateMethod
{
    public class FullLog : BaseLog
    {
        protected override string ReadDetails()
            => "Full log!";
    }
}
