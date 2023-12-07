using System.Collections.Generic;
using Zenject;

namespace DoubleBuffering
{
    public class Scene : ITickable
    {
        private FrameBuffer _currentBuffer;
        private FrameBuffer _nextBuffer;

        public Scene(List<FrameBuffer> buffer)
        {
            _currentBuffer = buffer[0];
            _nextBuffer = buffer[1];
        }
       
        public FrameBuffer Buffer => _currentBuffer;

        public void Tick()
        {
            _nextBuffer.Clear();

            _nextBuffer.Draw(1, 1);
            _nextBuffer.Draw(4, 1);

            // <- Heavy-handed action that can lead to a delay

            _nextBuffer.Draw(1, 3);
            _nextBuffer.Draw(2, 4);
            _nextBuffer.Draw(3, 4);
            _nextBuffer.Draw(4, 3);

            SwapBuffer();
        }

        private void SwapBuffer()
        {
            FrameBuffer temp = _currentBuffer;
            _currentBuffer = _nextBuffer;
            _nextBuffer = temp;
        }
    }
}
