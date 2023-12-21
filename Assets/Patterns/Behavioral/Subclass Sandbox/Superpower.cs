using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SubclassSandbox
{
    public class Superpower
    {
        private SoundPlayer _soundPlayer;

        public Superpower()
        {
            _soundPlayer = new SoundPlayer();
        }

        protected SoundPlayer SoundPlayer => _soundPlayer;

        public void Init(/*params*/)
        {
            Debug.Log("Initialize Superpower");
        }

        protected virtual void Activate() { }

        protected void Move(float x, float y, float z) 
            => Debug.Log($"Move hero: X = {x}, Y = {y}, Z = {z}");
        protected void SpawnParticles(int indexParticles, int count)
            => Debug.Log($"Spawn particles: {indexParticles}. Count = {count}");
    }
}
