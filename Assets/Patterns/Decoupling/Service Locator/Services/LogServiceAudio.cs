using UnityEngine;

namespace ServiceLocator
{
    public class LogServiceAudio : Audio
    {
        private Audio _wrapper;
        
        public LogServiceAudio(Audio wrapper)
            => _wrapper = wrapper;

        public override void PlaySound(int indexSound)
        {
            Debug.Log($"Sound Log - {indexSound}");
            _wrapper.PlaySound(indexSound);
        }
        public override void StopSound(int indexSound)
        {
            Debug.Log($"Sound Log - {indexSound}");
            _wrapper.StopSound(indexSound);
        }
        public override void StopAllSounds()
        {
            Debug.Log($"Stop all sounds Log!");
            _wrapper.StopAllSounds();
        }       
    }
}
