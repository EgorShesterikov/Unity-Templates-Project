using UnityEngine;

namespace Prototype
{
    public class Mage : Unit
    {
        public Mage(int damage, int heal, int speed) : base(damage, heal, speed)
            => Debug.Log("Created by Mage");

        override public Unit Clone()
            => new Mage(_damage, _heal, _speed);
    }

}