using UnityEngine;

namespace AbstractFactory
{
    public class Sword : Weapon
    {
        public override void Hit()
            => Debug.Log("Sword hit!");
    }
}
