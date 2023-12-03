using UnityEngine;

namespace Prototype
{
    public class War : Unit
    {
        public War(int damage, int heal, int speed) : base(damage, heal, speed)
            => Debug.Log("Created by War");

        override public Unit Clone()
            => new War(_damage, _heal, _speed);
    }

}