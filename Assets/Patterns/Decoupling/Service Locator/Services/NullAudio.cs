using UnityEngine;

namespace ServiceLocator
{
    public class NullAudio : Audio
    {
        public override void PlaySound(int indexSound)
            => Debug.Log($"Not initialize audio service!");

        public override void StopAllSounds()
            => Debug.Log($"Not initialize audio service!");
        public override void StopSound(int indexSound)
            => Debug.Log($"Not initialize audio service!");
    }
}
