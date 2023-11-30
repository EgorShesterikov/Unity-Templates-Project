namespace Flyweight
{
    public class Technica
    {
        private string _name;
        private int _seatsCount;
        private int _speed;

        public Technica(string name, int seatsCount, int speed)
        {
            _name = name;
            _seatsCount = seatsCount;
            _speed = speed;
        }

        public string Name => _name;
        public int SeatsCount => _seatsCount;
        public int Speed => _speed;
    }
}
