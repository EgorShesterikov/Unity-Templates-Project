using Zenject;

namespace Adapter
{
    public class AdapterInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Driver driver = new Driver();

            Car car = new Car();
            driver.Travel(car);

            Horse horse = new Horse();
            ITransport horseTransport = new CamelToTransportAdapter(horse);
            driver.Travel(horseTransport);
        }
    }
}
