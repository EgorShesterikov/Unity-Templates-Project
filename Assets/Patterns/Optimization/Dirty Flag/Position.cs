using UnityEngine;

namespace DirtyFlag
{
    public class Position
    {
        public static Position Origin() 
        {
            Debug.Log("Get origin position");
            return new Position(); 
        }

        public Position Combine(Position other) 
        {
            Debug.Log("Combine position");
            return new Position(); 
        }
    }
}
