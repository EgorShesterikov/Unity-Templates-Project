using UnityEngine;

namespace DoubleBuffering
{
    public class FrameBuffer
    {
        private Texture2D _texture;

        public FrameBuffer(FrameBufferConfig config)
            => _texture = config.Texture;

        public void Draw(int x, int y)
        {
            _texture.SetPixel(x, y, Color.black);
            _texture.Apply();
        }

        public void Clear()
        {
            for (int i = 0; i < _texture.width; i++)
                for (int j = 0; j < _texture.height; j++)
                    _texture.SetPixel(i, j, Color.white);
        }

        public Color[] GetPixels()
            => _texture.GetPixels();
    }
}
