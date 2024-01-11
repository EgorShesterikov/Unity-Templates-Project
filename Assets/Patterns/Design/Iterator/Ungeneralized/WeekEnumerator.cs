using System.Collections;

namespace Iterator
{
    public class WeekEnumerator : IEnumerator
    {
        private string[] _days;
        private int _position = -1;

        public WeekEnumerator(string[] days)
            => _days = days;
        
        public object Current
        { 
            get
            {
                if (_position == -1 || _position >= _days.Length)
                    throw new System.ArgumentException();

                return _days[_position];
            }
        }

        public bool MoveNext()
        {
            if(_position < _days.Length - 1)
            {
                _position++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
            => _position = -1;
    }
}
