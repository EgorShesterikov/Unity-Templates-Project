using UnityEngine;

namespace Prototype
{
    public class Archer : Unit
    {
        public Archer(int damage, int heal, int speed) : base(damage, heal, speed)
            => Debug.Log("Created by Archer");

        override public Unit Clone()
            => new Archer(_damage ,_heal, _speed);
    }

}