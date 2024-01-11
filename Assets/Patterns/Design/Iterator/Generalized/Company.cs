using System.Collections.Generic;

namespace Iterator
{
    public class Company
    {
        private Person[] _personnel;

        public Company(Person[] personnel) 
            => _personnel = personnel;

        public int Lenght => _personnel.Length;
        
        public IEnumerator<Person> GetEnumerator()
        {
            for (int i = 0; i < _personnel.Length; i++)
            {
                yield return _personnel[i];
            }
        }
    }
}
