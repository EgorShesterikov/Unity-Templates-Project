using UnityEngine;

namespace AbstractFactory
{
    public class RunMovement : Movement
    {
        public override void Move()
            => Debug.Log("Run move!");
    }
}
