using UnityEngine;

namespace DataLocality
{
    public class Particle
    {
        private bool _isActive;

        public bool IsActive => _isActive;

        public void SetActiv(bool value)
            => _isActive = value;

        public void Update() 
            => Debug.Log("Particle animation");
    }
}
