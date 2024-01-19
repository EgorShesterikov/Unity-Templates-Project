namespace Adapter
{
    public class CamelToTransportAdapter : ITransport
    {
        private Horse _horse;

        public CamelToTransportAdapter(Horse horse)
            => _horse = horse;

        public void Drive()
            => _horse.Move();
    }
}
