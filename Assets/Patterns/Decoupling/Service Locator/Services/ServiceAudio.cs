using UnityEngine;

namespace ServiceLocator
{
    public class ServiceAudio : Audio
    {
        public override void PlaySound(int indexSound)
            => Debug.Log($"Play sound!");
        public override void StopSound(int indexSound)
            => Debug.Log($"Stop sound!");
        public override void StopAllSounds()
            => Debug.Log($"Stop all sounds!");
    }
}
