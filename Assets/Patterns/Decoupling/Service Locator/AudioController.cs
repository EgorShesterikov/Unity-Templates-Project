using System;

namespace ServiceLocator
{
    public class AudioController : IDisposable
    {
        private InputHandler _input;

        public AudioController(InputHandler input)
        {
            _input = input;

            _input.ClickedAlpha1 += PlaySound;
            _input.ClickedAlpha2 += StopSound;
            _input.ClickedAlpha3 += StopAllSound;
        }

        public void Dispose()
        {
            _input.ClickedAlpha1 -= PlaySound;
            _input.ClickedAlpha2 -= StopSound;
            _input.ClickedAlpha3 -= StopAllSound;
        }

        private void PlaySound()
            => Locator.GetAudio().PlaySound(UnityEngine.Random.Range(0, 10));

        private void StopSound()
            => Locator.GetAudio().StopSound(UnityEngine.Random.Range(0, 10));

        private void StopAllSound()
            => Locator.GetAudio().StopAllSounds();
    }
}
