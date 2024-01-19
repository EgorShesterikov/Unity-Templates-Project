using UnityEngine;

namespace AbstractFactory
{
    public class FlyMovement : Movement
    {
        public override void Move()
            => Debug.Log("Fly move!");
    }
}
