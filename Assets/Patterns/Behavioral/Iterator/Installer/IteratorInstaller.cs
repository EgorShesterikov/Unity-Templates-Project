using UnityEngine;
using Zenject;

namespace Iterator
{
    public class IteratorInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Week week = new Week();

            foreach (var day in week)
                Debug.Log(day);


            Person[] people = new Person[] { new Person("Egor"), new Person("Ulyana")};
            Company company = new Company(people);
            
            foreach(var peaple in company)
                Debug.Log(peaple.Name);
        }
    }
}
