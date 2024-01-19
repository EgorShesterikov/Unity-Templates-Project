using UnityEngine;

namespace Adapter
{
    public class Horse : IAnimal
    {
        public void Move()
            => Debug.Log("Horse is Move!");
    }
}
