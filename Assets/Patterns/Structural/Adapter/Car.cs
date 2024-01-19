using UnityEngine;

namespace Adapter
{
    public class Car : ITransport
    {
        public void Drive()
            => Debug.Log("Car is Drive!");
    }
}
