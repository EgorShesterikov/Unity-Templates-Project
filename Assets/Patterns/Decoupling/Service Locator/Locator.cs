using UnityEngine;

namespace ServiceLocator
{
    public static class Locator
    {
        private static Audio _audio;
        private static NullAudio _nullAudio = new NullAudio();

        public static void Initialize() => _audio = _nullAudio;

        public static void Provide(Audio audio)
        {
            if (_audio == null)
                _audio = _nullAudio;
            else
                _audio = audio;
        }

        public static Audio GetAudio()
            => _audio;
    }
}
