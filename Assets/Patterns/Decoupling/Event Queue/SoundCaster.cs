using System;

namespace EventQueue
{
    public class SoundCaster : IDisposable
    {
        private InputHandler _input;
        private Audio _audio;

        public SoundCaster(InputHandler input, Audio audio)
        {
            _input = input;
            _audio = audio;

            _input.ClickedQ += PlayDoubleSound;
            _input.ClickedW += PlayRandomSound;
        }

        public void Dispose()
        {
            _input.ClickedQ -= PlayDoubleSound;
            _input.ClickedW += PlayRandomSound;
        }

        private void PlayRandomSound()
            => _audio.PlaySaund(UnityEngine.Random.Range(0, 10), 25);

        private void PlayDoubleSound()
        {
            _audio.PlaySaund(0, 50);
            _audio.PlaySaund(0, 100);
        }
    }
}