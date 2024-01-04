using UnityEngine;
using Zenject;

namespace EventQueue
{
    public class Audio : ITickable
    {
        private const int MAX_PENDING = 16;

        private static PlayMessage[] _pending = new PlayMessage[MAX_PENDING];
        private static int _head;
        private static int _tail;

        public static void Init()
        {
            _head = 0;
            _tail = 0;
        }

        public void PlaySaund(int id, int volume)
        {
            for (int i = _head; i != _tail; i = (i + 1) % MAX_PENDING)
            {
                if (_pending[i].SoundID == id)
                {
                    _pending[i].Volume = Mathf.Max(volume, _pending[i].Volume);

                    return;
                }
            }

            if ((_tail + 1) % MAX_PENDING == _head) 
                throw new System.ArgumentOutOfRangeException(nameof(_tail));

            _pending[_tail].SoundID = id;
            _pending[_tail].Volume = volume;

            _tail = (_tail + 1) % MAX_PENDING;
        }

        public void Tick()
        {
            if (_head == _tail)
                return;

            Debug.Log($"Start sound: {_pending[_head].SoundID} - volume: {_pending[_head].Volume}");

            _head = (_head + 1) % MAX_PENDING;
        }
    }
}