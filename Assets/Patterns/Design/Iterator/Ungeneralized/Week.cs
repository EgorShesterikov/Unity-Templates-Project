using System.Collections;

namespace Iterator
{
    public class Week : IEnumerable
    {
        private string[] _days = { "Monday", "Tuesday", "Wednesday", "Thursday",
                         "Friday", "Saturday", "Sunday" };

        public IEnumerator GetEnumerator()
            => new WeekEnumerator(_days);
    }
}
