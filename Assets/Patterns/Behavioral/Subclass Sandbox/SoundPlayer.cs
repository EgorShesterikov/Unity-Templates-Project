using UnityEngine;

namespace SubclassSandbox
{
    public class SoundPlayer
    {
        public void PlaySound(int indexSound, float volume)
            => Debug.Log($"Play sound: {indexSound}. Volume = {volume}");

        public void StopSound(int indexSound)
            => Debug.Log($"Stop sound: {indexSound}.");

        public void Setvolume(float volume)
            => Debug.Log($"Sound volume set: {volume}.");
    }
}
