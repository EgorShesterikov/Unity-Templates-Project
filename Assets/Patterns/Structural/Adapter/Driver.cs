namespace Adapter
{
    public class Driver
    {
        public void Travel(ITransport transport)
            => transport.Drive();
    }
}
