using System.Collections.Generic;

namespace Flyweight
{
    public class TechnicalFactory
    {
        private Dictionary<string, Technica> _technicaPool;

        public TechnicalFactory()
            => _technicaPool = new Dictionary<string, Technica>();

        public Technica GetCar()
        {
            if (_technicaPool.ContainsKey("Car"))
                return _technicaPool["Car"];
            else
            {
                Technica technica = new Technica("Car", 4, 180);
                _technicaPool.Add(technica.Name, technica);

                return technica;
            }
        }

        public Technica GetBike()
        {
            if (_technicaPool.ContainsKey("Bike"))
                return _technicaPool["Bike"];
            else
            {
                Technica technica = new Technica("Bike", 1, 30);
                _technicaPool.Add(technica.Name, technica);

                return technica;
            }
        }

        public Technica GetPlane()
        {
            if (_technicaPool.ContainsKey("Plane"))
                return _technicaPool["Plane"];
            else
            {
                Technica technica = new Technica("Plane", 200, 600);
                _technicaPool.Add(technica.Name, technica);

                return technica;
            }   
        }
    }
}
