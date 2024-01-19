using UnityEngine;

namespace AbstractFactory
{
    public class Arbalet : Weapon
    {
        public override void Hit()
            => Debug.Log("Arbalet hit!");
    }
}
